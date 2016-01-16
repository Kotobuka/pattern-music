using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sanford.Multimedia.Midi;
using System.Threading;

namespace MidiPattern
{
    public partial class Form1 : Form
    {
        public List<int> notes; //all avaliable notes
        public List<NoteL> sequence;
        public OutputDevice outDevice;
        public List<int> allDistance;
        public int curNote;
        public int curDistance; //time between 2 notes
        public int curP; //counter for curDistance
        public int curVelocity; //velocity decrease per loop

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMode.SelectedIndex = 0;
            listBoxTone.SelectedIndex = 0;
            try
            {
               outDevice  = new OutputDevice(0);
            }
            catch
            {
                MessageBox.Show("Can't find MIDI output device");
                Application.Exit();
            }
            sequence = new List<NoteL>();
            notes = new List<int>();

        }

        /// <summary>
        /// Generates list of avaliable notes
        /// </summary>
        /// <param name="curNote">First note</param>
        /// <param name="count">Length of list</param>
        /// <param name="mode">Mode(single, double, single reverse, double reverse)</param>
        /// <param name="maj">True for major, false for minor</param>
        public void GenListNote(int curNote, int count, int mode, bool maj, int tone)
        {
            notes.Clear();
            if (mode < 2)
            {
                for (int i = 0; i < count; i++)
                {
                    notes.Add(curNote);
                    if ((curNote + tone) % 12 == ((maj)?4:2) || (curNote + tone) % 12 == ((maj)?11:7))
                    {
                        curNote++;
                    }
                    else
                    {
                        curNote += 2;
                    }
                    if (mode % 2 == 1) notes.Add(curNote);
                }
            }
            else
            {
                for (int i = count; i > 0; i--)
                {
                    notes.Add(curNote);
                    if ((curNote + tone) % 12 == ((maj) ? 5 : 3) || (curNote + tone) % 12 == ((maj) ? 0 : 8))
                    {
                        curNote--;
                    }
                    else
                    {
                        curNote -= 2;
                    }
                    if (mode % 2 == 1) notes.Add(curNote);
                }
            }
        }

        /// <summary>
        /// Start MIDI playback
        /// </summary>
        /// <param name="stNote">First note</param>
        /// <param name="count">Number of notes</param>
        /// <param name="bpm">Tempo</param>
        /// <param name="pat">Pattern</param>
        /// <param name="velocity">Velocity decrease</param>
        public void Start(int stNote, int count, int bpm, string pat, int velocity)
        {
            sequence = new List<NoteL>();
            try
            {
                allDistance = pat.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            }
            catch
            {
                textBoxPattern.Text = "Pattern is not valid";
                return;
            }
            curNote = 0;
            GenListNote(stNote, count, Math.Max(0,comboBoxMode.SelectedIndex), radioButtonMaj.Checked, Math.Max(0, listBoxTone.SelectedIndex));
            curDistance = 0;
            curP = 0;
            curVelocity = velocity;
            timerRhythm.Interval = 30000 / bpm;
            timerRhythm.Start();
        }

        /// <summary>
        /// Stop MIDI playback
        /// </summary>
        public void Stop()
        {
            timerRhythm.Stop();
            outDevice.Close();
            outDevice = new OutputDevice(0);
        }

        /// <summary>
        /// Start to play note
        /// </summary>
        /// <param name="note">Note number</param>
        /// <param name="v">Velocity</param>
        public void PlayNote(int note, int v)
        {
           
            ChannelMessage mess = new ChannelMessage(ChannelCommand.NoteOn, 0, note, v);

            outDevice.Send(mess);            
        }

        /// <summary>
        /// Stop note
        /// </summary>
        /// <param name="note">Note number</param>
        /// <param name="v">Velocity</param>
        public void StopNote(int note, int v)
        {
            ChannelMessage mess = new ChannelMessage(ChannelCommand.NoteOff, 0, note, v);

            outDevice.Send(mess);
        }


        private void timerTick(object sender, EventArgs e)
        {
            bool played = false;
            if(curP%allDistance[curDistance] == 0)
            {
                played = true;
                curP = 0;
                sequence.Add(new NoteL(notes[curNote]));
                curNote = (curNote+1)%notes.Count;
            }
            int counter = 0;
            for (int i = 0; i < sequence.Count; i++ )
                {
                    var curNote = sequence[i];
                    if (curNote.d % 32 == 0)
                    {
                        counter++;
                        PlayNote(curNote.n, curNote.v);
                        curNote.d = 1;
                    }
                    else if (curNote.d % 32 == 8) //length of note
                    {
                        StopNote(curNote.n, curNote.v);
                        curNote.d++;
                        curNote.v -= curVelocity;
                        if (curNote.v <= 0)
                        {
                            sequence.RemoveAt(i);
                            i--;
                        }
                    }
                    else
                    {
                        curNote.d++;
                    }
                }
            if(played && counter>1)
            {
                curDistance = (curDistance + 1) % allDistance.Count();
            }
            curP++;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start((int)numericStartNote.Value, (int)numericCount.Value, (int)numericBPM.Value, textBoxPattern.Text, (int)numericUpDown4.Value);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerRhythm.Stop();
            outDevice.Close();
        }
        
        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prevent OutOfRangeException
            if(comboBoxMode.SelectedIndex<2)
            {
                numericStartNote.Minimum = 12;
                numericStartNote.Maximum = 75;
            }
            else
            {
                numericStartNote.Minimum = 50;
                numericStartNote.Maximum = 127;
            }
        }

    }

    public class NoteL
    {
        /// <summary>
        /// Midi note number
        /// </summary>
        public int n;
        /// <summary>
        /// Loop detection
        /// </summary>
        public int d;
        /// <summary>
        /// Midi velocity
        /// </summary>
        public int v;
        /// <summary>
        /// Creates an instance of NoteL
        /// </summary>
        /// <param name="note">Midi note</param>
        public NoteL(int note)
        {
            d = 0;
            n = note;
            v = 127;
        }
    }
}
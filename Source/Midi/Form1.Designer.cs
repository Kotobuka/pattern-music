namespace MidiPattern
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerRhythm = new System.Windows.Forms.Timer(this.components);
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.numericStartNote = new System.Windows.Forms.NumericUpDown();
            this.numericCount = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericBPM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxTone = new System.Windows.Forms.ListBox();
            this.radioButtonMaj = new System.Windows.Forms.RadioButton();
            this.radioButtonMin = new System.Windows.Forms.RadioButton();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRhythm
            // 
            this.timerRhythm.Tick += new System.EventHandler(this.timerTick);
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(91, 8);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(261, 20);
            this.textBoxPattern.TabIndex = 0;
            this.textBoxPattern.Text = "8 6";
            // 
            // numericStartNote
            // 
            this.numericStartNote.Location = new System.Drawing.Point(91, 42);
            this.numericStartNote.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numericStartNote.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericStartNote.Name = "numericStartNote";
            this.numericStartNote.Size = new System.Drawing.Size(122, 20);
            this.numericStartNote.TabIndex = 1;
            this.numericStartNote.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            // 
            // numericCount
            // 
            this.numericCount.Location = new System.Drawing.Point(91, 74);
            this.numericCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCount.Name = "numericCount";
            this.numericCount.Size = new System.Drawing.Size(120, 20);
            this.numericCount.TabIndex = 2;
            this.numericCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 152);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(88, 64);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(106, 152);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(96, 64);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "BPM";
            // 
            // numericBPM
            // 
            this.numericBPM.Location = new System.Drawing.Point(91, 108);
            this.numericBPM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericBPM.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericBPM.Name = "numericBPM";
            this.numericBPM.Size = new System.Drawing.Size(120, 20);
            this.numericBPM.TabIndex = 10;
            this.numericBPM.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(256, 196);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Velocity decrease";
            // 
            // listBoxTone
            // 
            this.listBoxTone.FormattingEnabled = true;
            this.listBoxTone.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
            this.listBoxTone.Location = new System.Drawing.Point(324, 42);
            this.listBoxTone.Name = "listBoxTone";
            this.listBoxTone.Size = new System.Drawing.Size(52, 108);
            this.listBoxTone.TabIndex = 13;
            // 
            // radioButtonMaj
            // 
            this.radioButtonMaj.AutoSize = true;
            this.radioButtonMaj.Checked = true;
            this.radioButtonMaj.Location = new System.Drawing.Point(267, 42);
            this.radioButtonMaj.Name = "radioButtonMaj";
            this.radioButtonMaj.Size = new System.Drawing.Size(51, 17);
            this.radioButtonMaj.TabIndex = 14;
            this.radioButtonMaj.TabStop = true;
            this.radioButtonMaj.Text = "Major";
            this.radioButtonMaj.UseVisualStyleBackColor = true;
            // 
            // radioButtonMin
            // 
            this.radioButtonMin.AutoSize = true;
            this.radioButtonMin.Location = new System.Drawing.Point(267, 65);
            this.radioButtonMin.Name = "radioButtonMin";
            this.radioButtonMin.Size = new System.Drawing.Size(51, 17);
            this.radioButtonMin.TabIndex = 15;
            this.radioButtonMin.Text = "Minor";
            this.radioButtonMin.UseVisualStyleBackColor = true;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Mode 1",
            "Mode 2",
            "Mode 3",
            "Mode 4"});
            this.comboBoxMode.Location = new System.Drawing.Point(231, 108);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(87, 21);
            this.comboBoxMode.TabIndex = 16;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 238);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.radioButtonMin);
            this.Controls.Add(this.radioButtonMaj);
            this.Controls.Add(this.listBoxTone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericBPM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericCount);
            this.Controls.Add(this.numericStartNote);
            this.Controls.Add(this.textBoxPattern);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pattern";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericStartNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerRhythm;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.NumericUpDown numericStartNote;
        private System.Windows.Forms.NumericUpDown numericCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericBPM;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxTone;
        private System.Windows.Forms.RadioButton radioButtonMaj;
        private System.Windows.Forms.RadioButton radioButtonMin;
        private System.Windows.Forms.ComboBox comboBoxMode;
    }
}


# pattern-music

Midi music generator. Inspired by [this video] (https://www.youtube.com/watch?v=3Z8CuAC_-bg)

# Usage

Pattern - a positive numbers (preferably less than 32), separated by a space.
  For example: "8 6", "4 6 18 8", "6 4 8 2"
  
Start note - The first note of interval. You can find all codes [here] (http://cote.cc/w/wp-content/uploads/drupal/blog/logic-midi-note-numbers.png)

Count - length of interval

BPM - Beats Per Minute, tempo

Velocity decrease - The volume of note will be reduced by this number in each cycle step.

Mode:
1. Single note sequence (C, D, E...)
2. Double note sequence (C, D, D, E, E...)
3. Single reverse note sequence (C, B, A...)
4. Double reverse note sequence (C, B, B, A, A...)

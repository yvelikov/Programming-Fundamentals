namespace _05.NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NoteStatistics
    {
        public static void Main()
        {

            var inputFrequencies = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var notes = new List<string>(){"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            var frequencies = new List<double>() { 261.63, 277.18, 293.66, 311.13, 329.63 , 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            var notesList = new List<string>();

            for (int i = 0; i < inputFrequencies.Count; i++)
            {
                for (int j = 0; j < frequencies.Count; j++)
                {
                    if (frequencies[j] == inputFrequencies[i])
                    {
                        notesList.Add(notes[j]);
                    }
                }
            }

            Console.WriteLine("Notes: {0}",string.Join(" ",notesList));

            var naturalsNotesList = new List<string>();
            var sharpsNotesList = new List<string>();
            

            foreach (var note in notesList)
            {
                if (note.Contains("#"))
                {
                    sharpsNotesList.Add(note);
                }
                else naturalsNotesList.Add(note);
            }

            Console.WriteLine("Naturals: {0}", string.Join(", ", naturalsNotesList));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharpsNotesList));

            var naturalsSum = 0.0d;
            var sharpsSum = 0.0d;

            for (int i = 0; i < naturalsNotesList.Count; i++)
            {
                for (int j = 0; j < notes.Count; j++)
                {
                    if (naturalsNotesList[i] == notes[j])
                    {
                        naturalsSum += frequencies[j];
                    }
                }
            }

            Console.WriteLine("Naturals sum: {0}", naturalsSum);

            for (int i = 0; i < sharpsNotesList.Count; i++)
            {
                for (int j = 0; j < notes.Count; j++)
                {
                    if (sharpsNotesList[i] == notes[j])
                    {
                        sharpsSum += frequencies[j];
                    }
                }
            }

            Console.WriteLine("Sharps sum: {0}", sharpsSum);


        }
    }
}

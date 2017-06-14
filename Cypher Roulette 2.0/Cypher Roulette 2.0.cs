﻿using System;

namespace DataTypesExercises
{
    class Exercises
    {
        static void Main()
        {
            int wordsCount = int.Parse(Console.ReadLine());
            string output = string.Empty;
            string previousWord = string.Empty;
            bool toEnd = true;
            for (int i = 0; i < wordsCount; i++)
            {
                string currentWord = Console.ReadLine();
                if (currentWord == "spin")
                {
                    toEnd = !toEnd;
                    i--;
                }
                switch (toEnd)
                {
                    case (true): output += currentWord; break;
                    case (false): output = currentWord + output; break;
                }
                if (currentWord == previousWord)
                {
                    output = string.Empty;
                    if (currentWord == "spin")
                    {
                        toEnd = !toEnd; //<- Why if i have two or more consecutive times spin I have to leave the direction the way it was before the first "spin"
                    }
                    previousWord = currentWord;
                }

                previousWord = currentWord;
            }
            output = output.Replace("spin", string.Empty);
            Console.WriteLine(output);
        }
    }
}
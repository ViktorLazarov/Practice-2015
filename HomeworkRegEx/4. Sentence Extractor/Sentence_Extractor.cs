﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
 
namespace SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string sentencePattern = @"\b[\w\s,`()'-]+[.!?]";
            Regex regEx = new Regex(sentencePattern);
            MatchCollection matches = regEx.Matches(text);
            foreach (var match in matches)
            {
                if (match.ToString().Split(' ').Contains(word))
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
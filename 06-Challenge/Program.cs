﻿using System;
using System.IO;
using System.Linq;

namespace fixer
{
	class Program
	{
		#region Do not change this code
		static void Main(string[] args)
		{
			if (args.Length < 2)
			{
				Console.WriteLine("Usage: ");
				Console.WriteLine("  fixer.exe <trainingFile> <testingFile>");
				Console.WriteLine();
				Console.WriteLine("  Learn typos kinds on files pair: <trainingFile> and <trainingFile>.typos");
				Console.WriteLine("  Try to fix typos in file <testingFile>.typos");
				Console.WriteLine("  If <testingFile> exists, measure accuracy of the result");
				return;
			}
			//!!! Do not change this code!!!!
			var correctWords = File.ReadAllLines(args[0]);
			var wordsWithTypos = File.ReadAllLines(args[0] + ".typos");
			var words2ToFix = File.ReadAllLines(args[1] + ".typos");
			var fixer = new TyposFixer();
			fixer.Learn(correctWords.Zip(wordsWithTypos, Tuple.Create).ToArray());
			var fixedWords2 = words2ToFix.Select(fixer.FixWord).ToArray();
			File.WriteAllLines(args[1] + ".fixed", fixedWords2);
			if (File.Exists(args[1]))
			{
				var correctWords2 = File.ReadAllLines(args[1]);
				CheckAccuracy(correctWords2, words2ToFix, fixedWords2);
			}
		}

		private static void CheckAccuracy(string[] correctWords, string[] wordsToFix, string[] fixedWords)
		{
			Console.WriteLine("Checking algorithm accuracy");
			var triples =
				correctWords.Zip(wordsToFix, Tuple.Create).Zip(fixedWords, (t, w) => new {correct=t.Item1, toFix=t.Item2, fix=w}).ToArray();
			var notFixed = triples.Count(t => t.correct != t.toFix && t.fix == t.toFix);
			var wrongFixed = triples.Count(t => t.fix != t.toFix && t.fix != t.correct);
			var rightFixed = triples.Count(t => t.correct != t.toFix && t.fix == t.correct);
			double typosCount = triples.Count(t => t.correct != t.toFix);
			double fixesCount = triples.Count(t => t.fix != t.toFix);
			Console.WriteLine("Fixed {0:0.0%} of all typos", rightFixed / typosCount);
            if (fixesCount > 0)
			    Console.WriteLine("WrongFixes {0:0.0%} of all made fixes", 1 - rightFixed / fixesCount);
		}
		#endregion
	}
}

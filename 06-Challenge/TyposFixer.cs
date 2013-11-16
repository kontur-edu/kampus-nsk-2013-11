using System;
using System.Collections.Generic;
using System.Linq;

namespace fixer
{
	public class TyposFixer
	{
		// word_typo — список пар "оригинальное слово" — "слово, которое набрал наборщик".
		// тут вы можете собрать некоторую статистику про виды опечаток, которую потом использовать в методе FixWord
		public void Learn(Tuple<string, string>[] word_typo)
		{
			
		}
		
		public string FixWord(string word)
		{
			return word;
		}
	}
}
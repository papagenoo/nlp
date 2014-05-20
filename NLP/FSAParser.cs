using System;

namespace NLP
{
	public class FSAParser
	{
		string Regex;

		public FSAParser (string regex)
		{
			Regex = regex;
		}

		public FSA Parse()
		{
			FSA fsa = new FSA ("0", "2");
			return fsa;
		}
	}
}


using System;
using System.Collections.Generic;

namespace NLP
{
	public interface FSATransitions
	{
		void Add(string state, string input, string nextState);
		IList<string> Get (string state, string input);
	}
}


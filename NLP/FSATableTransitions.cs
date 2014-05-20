using System;
using System.Collections.Generic;

namespace NLP
{
	public class FSATableTransitions : FSATransitions
	{
		IDictionary<string, Dictionary<string, string>> Transitions;

		public FSATableTransitions () 
			: this(new Dictionary<string, Dictionary<string, string>> ())
		{
		}

		public FSATableTransitions (IDictionary<string, Dictionary<string, string>> transitions)
		{
			Transitions = transitions;
		}

		public void Add(string state, string input, string nextState)
		{
			if (!Transitions.ContainsKey (state))
				Transitions[state] = new Dictionary<string, string>();
			if (Transitions[state].ContainsKey(input)) {
				throw new FSATransitionException();
			}
			Transitions [state] [input] = nextState;
		}

		public IList<string> Get (string state, string input)
		{
			if (!Transitions.ContainsKey (state))
				return new string[] {};
			if (!Transitions [state].ContainsKey (input))
				return new string[] {};
			return new string[] { Transitions[state][input] };
		}

	}
}


using System;
using System.Collections;
using System.Collections.Generic;

namespace NLP
{
	//	public class DRecognize
	public class FSA
	{
		FSATransitions Transitions;
		string InitialState;
		string CurrentState;
		string AcceptState;

		public FSA (string initialState, string acceptState) : this(initialState, acceptState, new FSATableTransitions())
		{
		}

		public FSA (string initialState, string acceptState, FSATransitions transitions)
		{
			CurrentState = InitialState = initialState;
			AcceptState = acceptState;
			Transitions = transitions;
		}

		public FSA AddTransition(string state, string input, string nextState)
		{
			Transitions.Add (state, input, nextState);
			return this;
		}

		public IList<string> GetTransitions (string state, string input)
		{
			return Transitions.Get(state, input);
		}

//		public string GetNext(string input)
//		{
//			return GetTransition(CurrentState, input);
//		}

		public bool Recognize(IList<string> input)
		{
			int index = 0;
			CurrentState = InitialState;
			for (;;) {
				if (index == input.Count) {
					if (CurrentState == AcceptState) {
						return true;
					} else {
						return false;
					}
				} else {
					IList<string> transitions = GetTransitions (CurrentState, input[index]);
					if (transitions.Count > 0) {
						CurrentState = transitions [0];
						index++;
					} else {
						return false;
					}
				}
			}
		}


	}
}


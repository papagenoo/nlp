using System;

namespace NLP
{
	public class FSATransitionException : InvalidOperationException
	{
		public FSATransitionException () 
			: base("Transition for the input in the state already exists")
		{
		}
	}
}


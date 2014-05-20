using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NLP.Test
{
	[TestFixture ()]
	public class FSATransitionsTest
	{
		[Test ()]
		public void AddTransition ()
		{
			FSATransitions transitions = new FSATableTransitions ();
			transitions.Add ("0", "a", "1");
			IList<string> states = transitions.Get ("0", "a");
			Assert.IsTrue(states.Contains("1"));
		}

		[Test]
		[ExpectedException(typeof(FSATransitionException))]
		public void AddExistedTransitionThrowsException()
		{
			FSATransitions transitions = new FSATableTransitions ();
			transitions.Add ("0", "a", "1");
			transitions.Add ("0", "a", "1");
		}
	}
}


using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NLP.Test
{
	[TestFixture ()]
	public class FSATest
	{
		[Test ()]
		public void TestCase ()
		{
			FSA fsa = new FSA ("0", "1");
			fsa.AddTransition ("0", "a", "1");
			IList<string> state = fsa.GetTransitions ("0", "a");
			Assert.IsTrue (state.Contains("1"));
			Assert.IsTrue(fsa.Recognize (new string[] {"a"}));
		}

		[Test]
		[ExpectedException(typeof(FSATransitionException))]
		public void AddExistedTransitionThrowsException()
		{
			FSA fsa = new FSA ("0", "1");
			fsa.AddTransition ("0", "a", "1");
			fsa.AddTransition ("0", "a", "1");
		}
	}
}


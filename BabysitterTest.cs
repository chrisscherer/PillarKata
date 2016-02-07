// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using NUnit.Framework;

namespace BabysitterKata
{
	[TestFixture()]
	public class BabysitterTest
	{
		Babysitter b;

		[SetUp] public void Init()
		{
			b = new Babysitter();
		}

		[TearDown] public void Dispose()
		{
			b = null;
		}

		[Test()]
		public void whenBabysitterIsPassedAValidStartTimeItReturnsTheGivenTime ()
		{
			Assert.AreEqual("1800", b.SetStartTime("1800"));
		}

		[Test()]
		public void whenBabysitterIsPassedAnEarlyStartTimeItReturnsInvalid ()
		{
			Assert.AreEqual ("Invalid", b.SetStartTime("1400"));
		}
	}
}


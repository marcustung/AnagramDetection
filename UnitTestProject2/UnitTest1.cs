using NUnit.Framework;
using AnagramDetection;

namespace UnitTestProject1
{
	[TestFixture]
	public class UnitTest1
	{
		[TestFixture]
		public class Tests
		{
			[Test]
			[TestCase("foefet", "toffee", true)]
			[TestCase("Buckethead", "DeathCubeK", true)]
			[TestCase("Twoo", "Woot", true)]
			[TestCase("apple", "pale", false)]
			public static void FixedTest(string test, string original, bool result)
			{
				Assert.AreEqual(result, Kata.IsAnagram(test, original));
			}
		}
	}
}

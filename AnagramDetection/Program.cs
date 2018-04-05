using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramDetection
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}
	public class Kata
	{
		public static bool IsAnagram(string test, string original)
		{
			if (string.IsNullOrEmpty(test) || string.IsNullOrEmpty(original))
				return false;

			var testLookup = GetCollectionLookup(test);

			var originalLookup = GetCollectionLookup(original);

			return LookUpCompare(testLookup, originalLookup);
		}

		private static ILookup<string, char> GetCollectionLookup(string input)
		{
			return input.ToCharArray().ToLookup(p => p.ToString().ToLower());
		}

		private static bool LookUpCompare(ILookup<string, char> target, ILookup<string, char> source)
		{
			foreach (var item in source)
			{
				var compare = target.Where(o => o.Key == item.Key && o.Count() == item.Count());

				if (!compare.Any())
				{
					return false;
				}
			}

			return true;
		}
	}
}

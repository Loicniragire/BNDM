using System;
using System.Collections.Generic;

namespace BNDM
{
	public class BitManipulator
	{
		/// Sets the bit on for every occurrence of character 'v' in given string.
		/// ex: v = 'a' text = "banana" returns 010101
		/// ex: v = 't' text = "banana" returns 000000
		public static int setBit(char v, string text)
		{
			int result = 0;
			var bitsToSet = new List<uint>();
			var count = 0;
			for(var i = text.Length - 1; i >= 0; i--)
			{
				if(text[i] == v)
					result =(1 << count) | result;

				count++;
			}

			return result;
		}

		/// Returns the largest bit
		/// Ex: n = 5 -> Bit representation = 101 -> largest bit = 3 i.e length(bit representation)
		public static int largestBit(int n) => Convert.ToString(n, toBase:2).Length;

		// returns true if the kth digit on number 'n' is set.
		public static bool isKthDigitSet(int n, int k)
		{
			var tmp = 1 << k - 1;
			return (n & tmp) == 0 ? false : true;
		}
	}
}

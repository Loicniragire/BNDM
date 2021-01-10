using System.Collections.Generic;

// Implementation of 'Backward Nondeterministic Dawg Matching algorithm' for single string pattern matching.
namespace BNDM
{
	public class BNDM
	{
		public static List<int> search(string query, string text, Dictionary<char,int> qrepres)
		{
			var result = new List<int>();
			var pos = 0;

			while(pos <= text.Length - query.Length)
			{
				var last = query.Length;
				var j = query.Length;
				var d = 1;

				while(d != 0)
				{
					int b = 0;
					if(qrepres.ContainsKey(text[pos + j - 1]))
					{
						b = qrepres[text[pos + j - 1]];
					}

					d = d & b;
					j = j - 1;
					if(BitManipulator.isKthDigitSet(d,BitManipulator.largestBit(d)))
					{
						if(j > 0)
							last = j;
						else
							result.Add(pos);
					}

					d = d << 1;
				}

				pos += last;
			}
			
			return result;
		}

		public static Dictionary<char,int> preProcess(string query)
		{
			var result = new Dictionary<char, int>();

			for(var i = 0; i < query.Length; i++)
			{
				if(!result.ContainsKey(query[i]))
				{
					result.Add(query[i], BitManipulator.setBit(query[i], query));
				}
			}

			return result;
		}
	}
}

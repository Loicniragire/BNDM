using System;
using System.Collections.Generic;

namespace BNDM
{
    public class Program
    {
		// First argument set to Query string
		// Second argument set to Text to search
        static void Main(string[] args)
        {
			var q = args[0];
			var t = args[1];

			var b = BNDM.preProcess(q);
			List<int> occurrences = BNDM.search(q, t, b);
			Console.WriteLine($"Query: {q} - Text: {t}");
			foreach(var occurrence in occurrences)
			{
				Console.WriteLine($"Occurrence at index: {occurrence}");
			}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
	class Program
	{
		static void Main(string[] args)
		{
			//flip this to change the output from one half of the problem to the other
			bool Part1 = false;
			System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\input.txt");
			string line;

			var data = new Dictionary<int, Dictionary<char, int>>();

			for (int i = 0; i < 8; i++)
			{
				data.Add(i, new Dictionary<char, int>());
			}

			while ((line = file.ReadLine()) != null)
			{
				for (int i = 0; i < 8; i++)
				{
					char curChar = line.ElementAt(i);
					if(data[i].ContainsKey(curChar))
					{
						data[i][curChar]++;
					} else
					{
						data[i].Add(curChar, 0);
					}
				}
			}

			for (int i = 0; i < 8; i++)
			{
				if (Part1)
				{
					Console.Write(data[i].ToList().OrderByDescending(x => x.Value).First().Key);
				} else
				{
					Console.Write(data[i].ToList().OrderBy(x => x.Value).First().Key);
				}
			}
			Console.WriteLine();
			Console.WriteLine("Press any key to finish");
			Console.ReadKey();
		}
	}
}

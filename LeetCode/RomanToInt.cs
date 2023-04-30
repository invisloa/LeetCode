using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class RomanToInt
	{

		Dictionary<string, int> romanToIntDictionary = new Dictionary<string, int>()
		{
		{ "I",1 },
		{ "V",5 },
		{ "X",10 },
		{ "L",50 },
		{ "C",100 },
		{ "D",500 },
		{ "M",1000 }
		};
		int RomanToIntTransform(string s)
		{
			int resoultValue = 0;
			int prevValue = 0;

			for (int i = s.Length - 1; i >= 0; i--)
			{
				int currValue = romanToIntDictionary[s[i].ToString()];
				if (currValue < prevValue)
				{
					resoultValue -= currValue;
				}
				else
				{
					resoultValue += currValue;
				}
				prevValue = currValue;
			}
			char b = s[0];
			return resoultValue;
		}
	}
}

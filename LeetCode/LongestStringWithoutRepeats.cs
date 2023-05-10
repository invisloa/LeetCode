using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class LongestStringWithoutRepeats
	{
		public int LengthOfLongestSubstringList(string s)
		{
			List<char> charList = new List<char>();
			int right = 0, maxLength = 0;
			int left = 0;
			while (right < s.Length)
			{
				if (!charList.Contains(s[right]))
				{
					charList.Add(s[right]);
					right++;
				}
				else
				{
					maxLength = Math.Max(maxLength, charList.Count);
					left = s.IndexOf(s[right], left) + 1;
					right = left;
					charList.Clear();
				}
			}
			maxLength = Math.Max(maxLength, charList.Count);
			return maxLength;
		}

		string LengthOfLongestSubstring(string s)
		{

			string longestDifferentLetters = "";
			for (int i = 0; i < s.Length; i++)
			{
				string tempCompare = "";
				for (int j = i; j < s.Length; j++)
				{
					if (tempCompare.Contains(s[j]))
					{
						break;
					}
					else
					{
						tempCompare += s[j];
						if (tempCompare.Length > longestDifferentLetters.Length)
						{
							longestDifferentLetters = tempCompare;
						}
					}
				}
			}
			return longestDifferentLetters;
		}
		int LengthOfLongestSubstringInt(string s)
		{
			Dictionary<char, int> set = new Dictionary<char, int>();
			int maxSub = 0;

			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				if (!set.ContainsKey(c))
				{
					set.Add(c, i);
					maxSub = Math.Max(set.Count, maxSub);
				}
				else
				{
					i = set[c];
					set.Clear();
				}
			}
			return maxSub;
		}
	}
}

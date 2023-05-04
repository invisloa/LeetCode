using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class LongestStringWithoutRepeats
	{
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
		int LengthOfLongestSubstringHash(string s)
		{
			HashSet<char> charSet = new HashSet<char>();
			int left = 0, right = 0, maxLength = 0;
			while (right < s.Length)
			{
				if (!charSet.Contains(s[right]))
				{
					charSet.Add(s[right]);
					right++;
					maxLength = Math.Max(maxLength, charSet.Count);
				}
				else
				{
					charSet.Remove(s[left]);
					left++;
				}
			}
			return maxLength;
		}

	}
}

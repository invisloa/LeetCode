using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class ZigZagStringConverter
	{
		static string Convert(string s, int numRows)
		{
			if (numRows == 1)
				return s;
			string convertedString = string.Empty;

			List<string> stringRows = new List<string>();

			for (int rowIndex = 0; rowIndex < numRows; rowIndex++)
			{
				stringRows.Add("");
			}

			int activeRow = 0;
			bool isAscending = true;

			foreach (char character in s)
			{
				isAscending = activeRow == numRows - 1 ? false : (activeRow == 0 ? true : isAscending);

				stringRows[activeRow] += (character.ToString());

				activeRow = isAscending ? activeRow + 1 : activeRow - 1;
			}

			foreach (string row in stringRows)
			{
				convertedString += row;
			}

			return convertedString;
		}
	}
}

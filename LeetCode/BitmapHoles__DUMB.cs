using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class BitmapHoles__DUMB
	{
		static string BitmapHoles(string[] strArr)
		{

			// code goes here  
			int countHoles = 0;
			int rows = strArr.Length;
			int cols = strArr[0].Length;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (strArr[i][j] == '0')
					{
						countHoles++;
						FillRegion(strArr, i, j, rows, cols);
					}
				}
			}
			return countHoles.ToString();

		}

		static void FillRegion(string[] strArray, int i, int j, int rows, int cols)
		{
			if (i < 0 || j < 0 || i >= rows || j >= cols || strArray[i][j] != '0')
			{
				return;
			}

			strArray[i] = strArray[i].Remove(j, 1).Insert(j, "H");
			FillRegion(strArray, i - 1, j, rows, cols);
			FillRegion(strArray, i + 1, j, rows, cols);
			FillRegion(strArray, i, j - 1, rows, cols);
			FillRegion(strArray, i, j + 1, rows, cols);
		}
	}
}

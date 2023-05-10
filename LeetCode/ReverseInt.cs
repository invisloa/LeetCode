using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class ReverseInt
	{
		static int Reverse(int x)
		{
			bool isSmallerThenZero = false;
			if (x < 0)
			{ isSmallerThenZero = true; }

			int returnInt = 0;
			string stringedX = x.ToString();
			if (stringedX.Length == 1) { return x; }
			if (isSmallerThenZero)
			{ stringedX = stringedX.Substring(1); }
			while (stringedX.Last() == '0')
			{
				stringedX = stringedX.Substring(0, stringedX.Length - 1);
			}
			stringedX = new string(stringedX.Reverse().ToArray());
			if (Int32.TryParse(stringedX, out returnInt)) { return isSmallerThenZero ? -returnInt : returnInt; }
			else return 0;
		}

		static int ReverseMathematic(int x)
		{
			int y = 0;
			while (x != 0)
			{
				// check if adding the last digit of x to y will cause overflow
				if (y > Int32.MaxValue / 10 || y < Int32.MinValue / 10)
				{
					return 0;
				}
				// get the last digit of x and add it to y
				y = y * 10 + x % 10;
				// remove the last digit of x
				x /= 10;
			}
			return y;
		}

	}
}

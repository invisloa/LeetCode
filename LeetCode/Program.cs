using LeetCode;

Console.WriteLine(IntToRoman(20));
static string IntToRoman(int num)
{
	string resoultRomanNumber = string.Empty;
	while (num >=1000)
	{
		resoultRomanNumber += "M";
		num -= 1000;
	}
	if(num>=900)
	{
		resoultRomanNumber += "CM";
		num -= 900;
	}
	if(num>=500)
	{
		resoultRomanNumber += "D";
		num -= 500;
	}
	if (num >= 400)
	{
		resoultRomanNumber += "CD";
		num -= 400;
	}
	while(num >=100)
	{
		resoultRomanNumber += "C";
		num -= 100;
	}
	if(num>=90)
	{
		resoultRomanNumber += "XC";
		num -= 90;
	}
	if(num >= 50)
	{
		resoultRomanNumber += "L";
		num -= 50;
	}
	if (num >= 40)
	{
		resoultRomanNumber += "XL";
		num -= 40;
	}
	while  (num >= 10)
	{
		resoultRomanNumber += "X";
		num -= 10;
	}
	if (num >= 9)
	{
		resoultRomanNumber += "IX";
		num -= 9;
	}
	if (num >= 5)
	{
		resoultRomanNumber += "V";
		num -= 5;
	}
	if (num >= 4)
	{
		resoultRomanNumber += "IV";
		num -= 4;
	}
	while (num >= 1)
	{
		resoultRomanNumber += "I";
		num -= 1;
	}
	return resoultRomanNumber;
}




Dictionary<string, int> romanDictionary = new Dictionary<string, int>()
	{
		{ "I", 1 },
		{ "V", 5 },
		{ "X", 10 },
		{ "L", 50 },
		{ "C", 100 },
		{ "D", 500 },
		{ "M", 1000 }
	};
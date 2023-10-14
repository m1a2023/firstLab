namespace firstLab;

class mathPerform
{
	static void Main(string[] args)
	{
		string inputedString = Console.ReadLine(); 
		sortMath(inputedString);
		Console.WriteLine("connection successful")
	}
	
	private static void sortMath(string input) //на вход принимается строка от пользователя
	{
		List<int> digits = new List<int>(); //ин-я списка чисел
		List<char> symbols = new List<char>(); //ин-я списка матсимволов
		
        string clearInput = ""; //ин-я переменной, хранящая любые символы, кроме пробелов

        for (int i = 0; i < input.Length; i++)
            if (input[i] != ' ') { clearInput += input[i]; } //если в строке есть символ или цифра, добавлю его в clearInput

        string timeDigitBox = ""; //временная переменная, хранящая цифры в числе

		for (int i = 0;  i < clearInput.Length; i++)
		{
            string updateTime = "";

			if (char.IsDigit(clearInput[i]))
				timeDigitBox += clearInput[i]; //наполнил переменную цифрами

			else
			{
				digits.Add(int.Parse(timeDigitBox)); // теперь нужно добавить числа в список
				symbols.Add(clearInput[i]); //после того, как встретил неЧисло - добавил число в список
                
                timeDigitBox = updateTime; //обновил переменную после того, как встретил нежелаемый символ
			}
		} 
		
		if (!string.IsNullOrEmpty(timeDigitBox))
        {
            digits.Add(int.Parse(timeDigitBox));
        }

        //outPut
        foreach ( int element in digits ) { Console.Write(element); } 
        Console.WriteLine();
		
		foreach ( char element in symbols) { Console.Write(element); }
        Console.WriteLine();
	}
}
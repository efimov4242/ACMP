System.Console.WriteLine("Введите три натуральных числа через пробел: ");
string s = Console.ReadLine();
string[] stringArray = s.Split(' ');
int[] numbArray = new int[stringArray.Length];
int max = 1;
for (int i = 0; i < stringArray.Length; i++)
{
	numbArray[i] = Convert.ToInt32(stringArray[i]);
	if (numbArray[i] > max)
		max = numbArray[i];

}

Console.WriteLine(max);
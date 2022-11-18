// Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно.

int SumBetween(int n)
{
	int sum = 0;
	for (int i = 1; i <= n; i++)
	{
		sum += i;
	}
	return sum;
}

System.Console.WriteLine(SumBetween(5));
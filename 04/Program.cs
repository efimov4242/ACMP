// в заданном наборе целых чисел найти сумму всех положительных элементов, затем найти где в заданной последовательности находятся максимальный и минимальный элемент и вычислить произведение чисел, расположенных в этой последовательности между ними.

int GetSumPositive(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if(array[i] >= 0)
		sum += array[i];
	}
	return sum;
}

int GetMultiplySequence(int[] array)
{
	int imin = 0;
	int imax = 0;
	int result = 1;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < array[imin])
			imin = i;
		if (array[i] > array[imax])
			imax = i;
	}
	for (int j = imin+1; j < imax; j++)
	{
		result *= array[j];
	}
	return result;
}

int[] someArray = {-7, 5, -1, 3, 9};


System.Console.WriteLine(GetSumPositive(someArray) + " " + GetMultiplySequence(someArray));

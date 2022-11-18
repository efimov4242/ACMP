int[] array = {0, 1, 5, 4, 3};


int[] GetArrayAscending(int[] array)
{
	int temp = 0;
	for (int j = 0; j < array.Length; j++)
	{
		for (int i = 0; i < array.Length-1; i++)
		{
			if(array[i] > array[i+1])
			{
				temp = array[i];
				array[i] = array[i+1];
				array[i+1] = temp;
			}
		}
	}
	return array;
}



int GetMinExcluded(int[] array)
{
	int minElement = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if(array[i] != i)
			minElement = i;
				break;
	}
	return minElement;
}


void GetPrintArray(int[] array)
{
	foreach (var item in array)
	{
		Console.Write(item);
	}
}


int[] arrayAscending = GetArrayAscending(array);
Console.WriteLine(GetMinExcluded(arrayAscending));
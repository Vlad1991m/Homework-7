﻿double[,] CreateRandom2dArray(int rows, int columns)
{
	double[,] newArray = new double[rows, columns];

	for(int i = 0; i < rows; i++)
		for(int j = 0; j < rows; j++)
			newArray[i,j] = new Random().NextDouble()*10;
	return newArray;
}
void Show2dArray(double[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);


int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j= 0; j < rows; j++)
            newArray[i,j] = new Random().Next(1,9);

    return newArray;
}
string PositionSearch(int[,] array, int i, int j)
{       string result = string.Empty; 
        if(i < array.GetLength(0) && j < array.GetLength(1)) 
        return result += array[i,j];
        else return "This element does not exist in current array";
       
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input row index: ");
int a  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column index: ");
int b  = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
Console.WriteLine();
Console.WriteLine($"Element index value [{a},{b}]: {PositionSearch(myArray, a, b)}");
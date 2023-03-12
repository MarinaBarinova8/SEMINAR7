// Задача 47. Задайте двумерный массив размерои m*n, 
// заполненный случайными вещественными числами
// m=3, n=4. -0,57 -2    -0,2
//               1 -3,38 -9,9
//            87,8 -7,1   9

double[,] Create2DArray(int row, int column, int minVal, int maxVal)
{
    double[,] create2DArray = new double [row, column];
    
    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            create2DArray[i,j]= Math.Round((new Random().Next(minVal, maxVal)) + (new Random().NextDouble()), 2);
        }
    }
    return create2DArray;
}
void Show2dArray(double [,] array) 
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

double [,] creatArray = Create2DArray(rows, columns, minVal, maxVal);
Show2dArray(creatArray);

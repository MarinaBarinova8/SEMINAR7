// Задача 52/Задайте двумерный массив из целых чисел. найдите среднее арифметическое в каждом столбце
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;3

int [,] Create2dArray()
{

    Console.Write("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] createdArray = new int [rows, columns];
    for (int i=0; i< rows; i++)
    {
        for (int j=0; j< columns; j++)
        {
            createdArray[i,j] = new Random().Next(minVal, maxVal +1);
        }
    }
    return createdArray;
}

void Show2dArray(int [,] array)
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

int[,] newArray = Create2dArray();
Show2dArray(newArray);

for (int j = 0; j < newArray.GetLength(1); j++)
{
    double sum = 0;
    double arithmeticMeanj = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        sum+=newArray[i,j];
        arithmeticMeanj = Math.Round((sum / newArray.GetLength(0)), 1); 
    }
    Console.WriteLine($"Arithmetic mean  is {arithmeticMeanj}");
}
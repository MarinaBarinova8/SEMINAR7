// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
// и возвращает значение этого элемента или же указание, что такого элемента нет
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// 17 числа с такими инденксами нет в массиве (первая строка 7 элемент)

int[,] Create2dArray()
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
Console.Write("Input number of line: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number number per line: ");
int numLine = Convert.ToInt32(Console.ReadLine());
int a = line -1;
int b = numLine -1;


if(line < 0 | line >newArray.GetLength(0) && numLine < 0 | numLine > newArray.GetLength(1))
Console.WriteLine($"A number with  index {line} {numLine} is not in the array!");
else  
Console.WriteLine($"{line} {numLine} ->" + newArray[a,b]);

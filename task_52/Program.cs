// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за строки
    {
        for(int j = 0; j < inArray.GetLength(1); j++)  //GetLength(1) отвечает за столбцы
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();    // функционал пустой строки для отображения таблицы (т.е. каждый ряд с новой строки)
    }
}


double[] GetColumnAverageNumber(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        average[j] = Math.Round(sum / array.GetLength(0), 2);
    }
    return average;
}




int rows = Prompt("Enter the number of rows in the array: ");
int columns = Prompt("Enter the number of columns in the array: ");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] averageColumns = GetColumnAverageNumber(array);
Console.WriteLine($"Average number of each calomns: {String.Join("; ", averageColumns)}");

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за строки
    {
        for (int j = 0; j < inArray.GetLength(1); j++)  //GetLength(1) отвечает за столбцы
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();    // функционал пустой строки для отображения таблицы (т.е. каждый ряд с новой строки)
    }
}


int GetMinSumAndRow(int[,] arr)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)  // цикл для прохождения по одной (первой) строке для присвоения значения переменной minSum
    {
        minSum += arr[0, i]; // указание на первую строку
    }
    Console.Write($"{minSum} ");
    for(int i = 1; i < arr.GetLength(0); i++)   // цикл начинаем с первой строки, т.к. нулевая уже пройдена предыдущим циклом и присвоена minSum
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        Console.Write($"{sum} ");
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row + 1;
}





int rows = Prompt("Enter the number of rows in the array: ");
int columns = Prompt("Enter the number of columns in the array: ");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int sumArray = GetMinSumAndRow(array);
Console.WriteLine();
Console.WriteLine($"Minimum sum is in the row {sumArray}");




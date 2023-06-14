// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец


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


int Prompt2(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


void GetElementsValue(int[,] resultArray, int row, int column)
{
    int value = 0;
    if (row <= resultArray.GetLength(0) && column <= resultArray.GetLength(1))
    {
        value = resultArray[row, column];
        Console.WriteLine($"Element's value on this position in array: {value}");
    }
    else if (row > resultArray.GetLength(0) || column > resultArray.GetLength(1))
    {
        Console.WriteLine("This number is not in array!");
    }
}



int rows = Prompt("Enter the number of rows in the array: ");
int columns = Prompt("Enter the number of columns in the array: ");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
int row = Prompt2("Enter the row of element's position: ");
int col = Prompt2("Enter the column of element's position: ");
GetElementsValue(array, row, col);


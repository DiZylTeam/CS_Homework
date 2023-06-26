// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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



void SelectionSortMaxMin(int[,] arr)    // метод сортировки строк массива от max к min или наоборот
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)  // в данном случае j отвечает за многократный проход по строке для перебора элементов
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)  // вводим переменную k для сравнения элементов 
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int tempMax = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = tempMax;
                }
            }
        }
    }
}



int rows = Prompt("Enter the number of rows in the array: ");
int columns = Prompt("Enter the number of columns in the array: ");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
SelectionSortMaxMin(array);
PrintArray(array);


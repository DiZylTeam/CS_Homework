// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    Random rand = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = rand.NextDouble()*100;   // функционал, который выводит случайные вещественные числа
        }
    }
    return result;
}


void PrintArray(double[,] inArray)
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



int rows = Prompt("Enter the number of rows in the array: ");
int columns = Prompt("Enter the number of columns in the array: ");
double[,] array = GetArray(rows, columns, -1, 1);
PrintArray(array);


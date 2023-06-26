// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18





int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}



int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 10);
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


int[,] MatrixMult(int[,] matrixA,int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] result = new int[rowsA, columnsB];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                for (int n = 0; n < matrixA.GetLength(1); n++)
                {
                    result[i, j] += matrixA[i, n] * matrixB[n, j];
                }
            }
        }
    }
    return result;
}


int rowsA = Prompt("Enter the number of rows in the arrayA: ");
int columnsA = Prompt("Enter the number of columns in the arrayA: ");
int[,] array1 = GetArray(rowsA, columnsA);
PrintArray(array1);
int rowsB = Prompt("Enter the number of rows in the arrayB: ");
int columnsB = Prompt("Enter the number of columns in the arrayB: ");
int[,] array2 = GetArray(rowsB, columnsB);
PrintArray(array2);
Console.WriteLine();
int[,] multArrays = MatrixMult(array1, array2);
Console.WriteLine();
PrintArray(multArrays);


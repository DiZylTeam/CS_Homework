// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++) 
    {
        res[i] = new Random().Next(0, 20);
    }
    return res; 
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void FindSumOddElements(int[] arr2) 
{
int count = 0;
int sum = 0;
while (count < arr2.Length)
{
    if (count % 2 > 0)
    {
    sum = sum + arr2[count];
    }
    count++;
}
Console.WriteLine($"Sum of odd array's elements: {sum}");
}


int[] array = GetArray(10);
PrintArray(array);
Console.WriteLine();
FindSumOddElements(array);

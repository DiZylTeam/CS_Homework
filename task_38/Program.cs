// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++) 
    {
        res[i] = new Random().NextDouble()*100;
    }
    return res; 
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]} ");
    }
}

void FindSubtractionMaxMinElements(double[] arr2) 
{
int count = 1;
double min = arr2[0];
double max = arr2[0];
double tempMin = min;
double tempMax = max;
double sub = 0;
while (count < arr2.Length)
{
    if (arr2[count] > arr2[count - 1])
    {
        tempMax = arr2[count];
        tempMin = arr2[count - 1];
    }
    else
    {
        tempMax = arr2[count - 1];
        tempMin = arr2[count];
    }
    if (tempMax > max)
    {
        max = tempMax;
    }
    else if (tempMin < min)
    {
        min = tempMin;
    }
    count++;
}
sub = max - min;
Console.WriteLine($"Max array's element: {max}");
Console.WriteLine($"Min array's element: {min}");
Console.WriteLine($"Subtraction of max/min array's elements: {sub}");
}


double[] array = GetArray(10);
PrintArray(array);
Console.WriteLine();
FindSubtractionMaxMinElements(array);


// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Prompt(string massage)  // создаем метод для считвания числа с консоли
{
    Console.Write(massage); // выводит сообщение
    int resArray = Convert.ToInt32(Console.ReadLine()); // считывает строку и преобразует её в целое число типа int
    return resArray;
}

int[] GetArray(int length)  // создаем метод для ввода нового массива
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Enter {i + 1} numbers: ");
    }
    return array;

}


void PrintArray(int[] arr)  // метод для вывода массива на консоль
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int NumMoreZero(int[] array)    // метод для поиска чисел, больше нуля
{
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}
return count;
}


// исполнение методов
int length = Prompt($"Enter quantity of numbers: ");
int[] array = GetArray(length);;
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Quantity of numbers more than zero: {NumMoreZero(array)}");




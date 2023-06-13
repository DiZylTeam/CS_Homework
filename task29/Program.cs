// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int Prompt(string message)  // метод для ввода числа с экрана
{
Console.Write(message); // приглашение к вводу числа
int number = int.Parse(Console.ReadLine()); // преобразование в число
return number;
}


int[] GetArray(int length, int minValue, int maxValue)  // метод для получения массива из рандомных чисел
{
int[] array = new int[length];  // объявляем новый массив
Random random = new Random();   // функционал для рандомных чисел
for (int i = 0; i < length; i++)
{
    array[i] = random.Next(minValue, maxValue + 1); // функционал для заполнения массива рандомными числами из заданного диапазона
}
return array;
}

void PrintArray(int[] array)    // метод для вывода массива на экран
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");  // вывод массива
    }
    Console.Write($"{array[array.Length - 1]}");    // вывод массива
}

int lengthArray = Prompt("Array's length: ");
int minNum = Prompt("The first number: ");
int maxNum = Prompt("The last number: ");
int[] resArray = GetArray(lengthArray, minNum, maxNum);
PrintArray(resArray);






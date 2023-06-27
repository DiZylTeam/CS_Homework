// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


void GetNaturalNumbers(int number)
{
    if (number >= 1)
    {
        Console.Write($"{number} ");
        GetNaturalNumbers(number - 1);  // рекурсия, т.е. использование этого же метода в этом же методе
    }
}


int number = Prompt("Enter a natural number: ");
if (number <= 0) Console.WriteLine($"Invalid value");
GetNaturalNumbers(number);







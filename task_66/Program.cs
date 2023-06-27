// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


int GetSumNumbers(int number1, int number2)
{
    if (number1 > number2)
    {
        return 0;
    }
    return number1 + GetSumNumbers(number1 + 1, number2);  // рекурсия, т.е. использование этого же метода в этом же методе
}




int number1 = Prompt("Enter the first natural number: ");
int number2 = Prompt("Enter the second natural number: ");
if (number1 > number2)                              // проверка на то, если пользователь ввел первое число больше, чем второе (переставляем их местами и выводим числа)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}
int sum = GetSumNumbers(number1, number2);
Console.WriteLine($"The sum of all natural numbers: {sum}");




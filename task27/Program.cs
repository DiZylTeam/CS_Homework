// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int Prompt(string message)
{
Console.Write(message);
int number = int.Parse(Console.ReadLine());
return number;
}

int SumOfAllDigits(int num)
{
int sum = 0;
while (num > 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
return sum;
}

int number = Prompt("Enter a number: ");
Console.WriteLine($"Sum of all number's digits: {SumOfAllDigits(number)}"); // сумма всех чисел числа



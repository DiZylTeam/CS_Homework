// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());


int i = 1;
int res = number1;
while(i < number2)
{
    res = res * number1;
    i++;
}
Console.WriteLine($"{res}");


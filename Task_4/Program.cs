// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Enter three numbers: ");
int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());
int number_3 = int.Parse(Console.ReadLine());
int max = number_1;
if (number_1 < number_2)
{
    max = number_2;
}
if (number_2 < number_3)
{
    max = number_3;
}
Console.WriteLine("Max number = " + max);
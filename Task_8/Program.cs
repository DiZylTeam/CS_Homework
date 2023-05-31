// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int minNumber = 1; // give a value of min number
if (number <= 1)
{
    Console.WriteLine("Invalid value!");
}
    while (minNumber <= number)
    {
        if (minNumber % 2 == 0)
        {
            Console.Write(minNumber + " ");
        }
    {
        minNumber = minNumber + 1;
    }
    }
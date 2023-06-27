// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


int Akkerman(int m, int n)
{
  if (m == 0) 
  {
    return n + 1;
  }
  if (m > 0 && n == 0) 
  {
    return Akkerman(m - 1, 1);
  }
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}





int m = Prompt("Enter the first number (m): ");
int n = Prompt("Enter the second number (n): ");
Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");


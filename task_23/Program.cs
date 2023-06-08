// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



int Prompt(string massage) 
{
    Console.Write(massage);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void FindCube(int num_n)
{
for (int n = 1; n <= num_n; n++)
{
int result = n * n * n;
Console.Write(result + " ");
}
}

int resNum = Prompt("Enter a number: ");
FindCube(resNum);

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



int Prompt(string massage) 
{
    Console.Write(massage);
    int num = int.Parse(Console.ReadLine());
    return num;
}


void CheckPalindrome(int num2)
{

if (num2 > 10000 && num2 < 100000)
{
    int d1 = num2 / 10000;
    int d2 = num2 % 10;
    int d3 = num2 / 1000 % 10;
    int d4 = (num2 / 10) % 10;
    if (d1 == d2 & d3 == d4)
{
    Console.WriteLine("Palindrome");
}
    else
{
    Console.WriteLine("Not palindrome");
}
}
else 
{
    Console.WriteLine("Invalid value");
}
}

int result = Prompt("Enter a five-digit number: ");
CheckPalindrome(result);


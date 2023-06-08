// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



int Prompt(string message) 
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}


void FindDistance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
double d3D = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine($"Distance in 3D: {d3D}");
}


int x1 = Prompt("Enter X point A: ");
int y1 = Prompt("Enter Y point A: ");
int z1 = Prompt("Enter Z point A: ");

int x2 = Prompt("Enter X2 point B: ");
int y2 = Prompt("Enter Y2 point B: ");
int z2 = Prompt("Enter Z2 point B: ");

FindDistance3D(x1, y1, z1, x2, y2, z2);




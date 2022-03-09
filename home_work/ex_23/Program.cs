void Cube(int number)
{
    Console.Write(number + " | ");
    for (int i = 1; i <= number; ++i)
    {
        Console.Write(Math.Pow(i, 3) + " | ");
    }
}

Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
Cube(a);
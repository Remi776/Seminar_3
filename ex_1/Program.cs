int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("0 < x < +infinity");
    Console.WriteLine("0 < y < +infinity");
}
else if (number == 2)
{
    Console.WriteLine("-infinity < x < 0");
    Console.WriteLine("0 < y < +infinity");
}
else if (number == 3)
{
    Console.WriteLine("-infinity < x < 0");
    Console.WriteLine("-infinity < y < 0");
}
else if (number == 4)
{
    Console.WriteLine("0 < x < +infinity");
    Console.WriteLine("-infinity < y < 0");
}
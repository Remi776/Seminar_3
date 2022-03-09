Console.WriteLine("Enter the A coordinates");
int a_x = Convert.ToInt32(Console.ReadLine());
int a_y = Convert.ToInt32(Console.ReadLine());
int a_z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the B coordinates");
int b_x = Convert.ToInt32(Console.ReadLine());
int b_y = Convert.ToInt32(Console.ReadLine());
int b_z = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((b_x - a_x), 2) + Math.Pow((b_y - a_y), 2) + Math.Pow((b_z - a_z), 2));
Console.WriteLine("Distance = " + distance);
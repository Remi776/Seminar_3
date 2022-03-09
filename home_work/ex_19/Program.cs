Console.Write("Enter five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
string num_str = Convert.ToString(num);
string result = "";
while (num > 0)
{
    result += Convert.ToString(num % 10);
    num /= 10;
}
if (num_str == result) 
{
    Console.WriteLine("It's a palindrome");
}
else 
{
    Console.WriteLine("It's not a palindrome");
}

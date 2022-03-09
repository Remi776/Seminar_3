void Palindrome(string number)
{
    int i = 0;
    while (i < number.Length / 2)
    {
        if (number[i] = number[number.Length - 1 - i])
        {
            i++;
            continue;
        }
        else
        {
            Console.WriteLine("it's not a palindrome");
            break;
        }
    Console.WriteLine("it's a palindrome");
    }
}

Palindrome(a);
Console.Write("Enter number: ");
string a = Console.ReadLine();


using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
int count = 0;
string[] str = new string[5];
Console.WriteLine("enter 5 words");
string rev = string.Empty;

for (int i = 0; i < str.Length; i++)
{

    str[i] = Convert.ToString(Console.ReadLine());

}


foreach (string s in str)
{
    bool isPalindrome = true;
    int length = s.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (s[i] != s[length - i - 1])
        {
            isPalindrome = false;
            break;
        }
    }

    if (isPalindrome)
    {
        Console.WriteLine(s);
        count++;
    }
}

Console.WriteLine($"The Number of palindrome words in the list is:{count} ");
Console.WriteLine();    


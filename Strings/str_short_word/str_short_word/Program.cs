using System.Globalization;

string[] str = new string[5];
Console.WriteLine("enter 5 words");

for (int i = 0; i < str.Length; i++)
{
    str[i] = Convert.ToString(Console.ReadLine());
}
string min = str[0];
foreach(string s in str)
{
    if (str.Length < min.Length)
    {
        min = s;
    }
}
Console.WriteLine($"The shortest word is {min}");
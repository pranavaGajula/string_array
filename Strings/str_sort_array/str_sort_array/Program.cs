using System.Collections.Immutable;

string[] str = new string[5];
Console.WriteLine("enter 5 words");
for (int i = 0; i < str.Length; i++)
{
    str[i] = Convert.ToString(Console.ReadLine());
}
//string min = str[0];
Console.WriteLine("The sorted array is : ");
Array.Sort(str);
foreach (string s in str)
{

    Console.WriteLine(s);
}


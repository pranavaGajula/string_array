string[] str = new string[5];
string word;
Console.WriteLine("enter 5 words");

for (int i = 0; i < str.Length; i++)
{
    str[i] = Convert.ToString(Console.ReadLine());
}
// string min = str[0];
Console.WriteLine("enter the word for search");
word = Convert.ToString(Console.ReadLine());
foreach (string s in str)
{
    if (word == s)
    {
        Console.WriteLine("word is present in the list");
    }
   
}
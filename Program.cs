// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string str = "str str str";
string str1 = "str1 str1 str1";
string str2 = "str";

Console.WriteLine(str.Length);

Console.WriteLine(str.ToUpper());

Console.WriteLine(str.ToLower());

Console.WriteLine(String.Concat(str, "Hi"));

Console.WriteLine(str.CompareTo(str1));

Console.WriteLine(String.Compare(str,str1,true));

Console.WriteLine(str.Contains(str2));

Console.WriteLine(str.EndsWith(str2));

Console.WriteLine(str.StartsWith(str2));

Console.WriteLine(str.IndexOf(str2));

Console.WriteLine(str.IndexOf("str1"));

Console.WriteLine(str.Insert(0,"Hello"));

Console.WriteLine(str.LastIndexOf("r"));

Console.WriteLine(str + str1.PadLeft(30));
Console.WriteLine(str + str1.PadLeft(30,'*'));

Console.WriteLine(str.PadRight(50));
Console.WriteLine(str.PadRight(50,'-'));


Console.WriteLine(str.Remove(10));
Console.WriteLine(str.Remove(5,3));
Console.WriteLine(str.Remove(0,1));

Console.WriteLine(str.Replace("str","STR"));
Console.WriteLine(str.Replace(" ", "*"));

Console.WriteLine(str.Split(' ')[0]);

Console.WriteLine(str.Substring(4));
Console.WriteLine(str.Substring(4,2));


//Console.ReadLine();


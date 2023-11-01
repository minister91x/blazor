// See https://aka.ms/new-console-template for more information
using ConsoleAppNet7;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
var p1 = new Person { Name = "Shehryar", Surname = "Khan" };
Person p2 = new("Shehryar", "Khan");

// Initializations with missing required properties 
var p3 = new Person { Name = "Shehryar", Surname = "" };

string name = "Shehryar";
string surname = "Khan";

string jsonString =
  $$"""
  {
    "Name": {{name}},
    "Surname": {{surname}}
  }
  """;

//byte[] array = "Hello World";

var numbers = new[] { 1, 2, 3, 4 };
// List and constant patterns 
Console.WriteLine(numbers is [1, 2, 3, 4]); // True 
Console.WriteLine(numbers is [1, 2, 4]); // False
// List and discard patterns 
Console.WriteLine(numbers is [_, 2, _, 4]); // True 
Console.WriteLine(numbers is [.., 3, _]); // True
// List and logical patterns 
Console.WriteLine(numbers is [_, >= 2, _, _]); // True
Console.WriteLine("Hello, World!", jsonString);


// switch expression in string interpolation 
int month = 5;
string season = $"The season is {
    month
    switch
{
    1 or 2 or 12 => "winter",
    > 2 and < 6 => "spring",
    > 5 and < 9 => "summer",
    > 8 and < 12 => "autumn",
}}.";

int[] numbers1 = new int[] { 1, 2, 3, 4, 5, 6 };
string message = $"The reversed even values of {nameof(numbers1)} are {string.Join(", ", numbers1.Where(n => n % 2 == 0)
      .Reverse())}.";


ReadOnlySpan<char> strSpan = "SK".AsSpan();
if (strSpan is "SK")
{
    Console.WriteLine("Hey, SK");
}


int n = -32;
Console.WriteLine($"Before shift: bin = {Convert.ToString(n, 2),32}, dec = {n}");

int a = n >> 2;
Console.WriteLine($"After >>: bin = {Convert.ToString(a, 2),32}, dec = {a}");

int b = n >>> 2;
Console.WriteLine($"After >>>: bin = {Convert.ToString(b, 2),32}, dec = {b}");

Console.WriteLine(season);
Console.WriteLine(message);


Console.ReadKey();



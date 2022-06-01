// See https://aka.ms/new-console-template for more information

//Variables
int a = 17;
int b = 4;
int quotient = a / b;
int remainder = a % b;

//Console Writing / Interation
Console.WriteLine($"17 / 4 is {quotient} remainder {remainder}");

Console.WriteLine();

Console.WriteLine("What is the radius of your circle?");

var radius = double.Parse(Console.ReadLine());

var area = Math.PI * Math.Pow(radius, 2);

Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");

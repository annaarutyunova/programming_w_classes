// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter a number: ");
string firstNumber = Console.ReadLine();
int a = int.Parse(firstNumber);
Console.WriteLine("Enter another number: ");
string secondNumber = Console.ReadLine();
int b = int.Parse(secondNumber);
Console.WriteLine("Enter one more number: ");
string thirdNumber = Console.ReadLine();
int c = int.Parse(thirdNumber);
int firstResult = (a + b) * c;
int secondResult = a * b + b * c;
Console.WriteLine(firstResult);
Console.WriteLine(secondResult);




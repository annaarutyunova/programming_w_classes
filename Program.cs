// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = new List<int>();

for (int i = 0; i<5; i++)
{
    Console.WriteLine("Enter Number: ");
    string input = Console.ReadLine();
    int number = int.Parse(input);
    numbers.Add(number);
}
// for (int i = 0; i < numbers.Count; i++) // prints out every item on the list
// {
//     Console.WriteLine(numbers[i]);
    
// }
int sum = 0;
sum = numbers.Sum();
Console.WriteLine($"The sum of all numbers in the list is {sum}");

double average = 0;
average = numbers.Average();
Console.WriteLine($"The average of the numbers in the list is {average}");

int largestNumber = 0;
for (int i = 0; i<numbers.Count; i++)
{
    if (numbers[i] > largestNumber)
    {
        largestNumber = numbers[i];
    }
    
}
Console.WriteLine($"The largest number in the list is {largestNumber}");

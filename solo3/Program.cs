// See https://aka.ms/new-console-template for more information
// Random randomGenerator = new Random();
// int number = randomGenerator.Next(1,11);
// Console.WriteLine(number);

Random randomGenerator = new Random();
int number = randomGenerator.Next(1,11);
int magicNumber = 0;

while (magicNumber != number)
{
    Console.WriteLine("Guess a number: ");
    string input = Console.ReadLine();
    magicNumber = int.Parse(input);
    
    
    if (magicNumber < number)
        {
            Console.WriteLine("Higher");
        }
    else if (magicNumber > number)
        {
            Console.WriteLine("Lower");
        }
    else
        {
            Console.WriteLine("You guessed the number!");
        }

}


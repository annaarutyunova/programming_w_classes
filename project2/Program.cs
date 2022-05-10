// See https://aka.ms/new-console-template for more information
// Console.Write("What is your first name? ");
// string first_name = Console.ReadLine();
// Console.Write("What is your last name? ");
// string last_name = Console.ReadLine();
// Console.WriteLine($"My name is {first_name} {last_name}.");

Console.Write("What is your grade percentage? ");
string gradePercentage = Console.ReadLine();
int grade = int.Parse(gradePercentage);
if (grade >= 90)
{  
    Console.WriteLine("Your grade is A.");
}
else if (grade >= 80 && grade < 90)
{
    Console.WriteLine("Your grade is B.");
}
else if (grade >= 70 && grade < 80)
{
    Console.WriteLine("Your grade is C.");
}
else if (grade >= 60 && grade < 70)
{
    Console.WriteLine("Your grade is D");
}
else
{
    Console.WriteLine("Your grade is F");
}



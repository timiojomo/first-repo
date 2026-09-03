Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name);

Console.WriteLine("Guess a number between 1 and 10:");
int firstGuess = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Make another guess:");
int secondGuess = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The sum of your guesses is: " + (firstGuess + secondGuess));



string password = "abcd1234";

Console.WriteLine("Enter your password:");
string input = Console.ReadLine();

while (input != password)
{
    Console.WriteLine("Incorrect password. Please try again:");
    input = Console.ReadLine();
}
Console.WriteLine("Login successful.");
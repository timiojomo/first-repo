int age = 16;

if (age >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}
else
{
    Console.WriteLine("You are not eligible to vote.");
}

int marks = 75;

if (marks >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (marks >= 75)
{
    Console.WriteLine("Grade: B");
}
else if (marks >= 50)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Grade: F");
}

int menuChoice = 4;
switch (menuChoice)
{
    case 1:
        Console.WriteLine("Yam and beans.");
        break;
    case 2:
        Console.WriteLine("Rice and stew.");
        break;
    case 3:
        Console.WriteLine("Jollof rice and chicken.");
        break;
    case 4:
        Console.WriteLine("Pounded yam and egusi soup.");
        break;
    default:
        Console.WriteLine("Invalid option selected.");
        break;
}
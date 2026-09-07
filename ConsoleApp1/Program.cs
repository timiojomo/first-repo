static void Greet(string name = "User")
{
    Console.WriteLine($"Hello, {name}! Welcome to the program!");
}

Greet();
Greet("Joan");

static void Add(int a, int b)
{
    int sum = a + b;
    Console.WriteLine($"{a} + {b} = {sum}");
}

Add(5, 9);

static int Multiply(int a, int b)
{
    return a * b;
}

int result = Multiply(4, 7);
Console.WriteLine($"4 x 7 = {result}");

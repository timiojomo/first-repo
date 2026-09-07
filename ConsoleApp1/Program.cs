int[] numbers = { 10, 20, 30, 40, 50 };
Console.WriteLine(numbers[2]);

for(int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]/10);
}

foreach(int number in numbers)
{
    Console.WriteLine(number * 2);
}

// 2D array
int[,] matrix = 
{ 
    { 1, 2, 3 }, 
    { 4, 5, 6 } 
};

Console.WriteLine(matrix[0, 1]);
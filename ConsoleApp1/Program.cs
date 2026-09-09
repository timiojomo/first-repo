double height, width, glassArea, woodLength;

Console.WriteLine("Enter the height of the window in metres:");
height = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the width of the window in metres:");
width = double.Parse(Console.ReadLine());

glassArea = 2 * (height * width);

woodLength = 2 * (height + width) * 3.25;

Console.WriteLine($"The area of the glass is: {glassArea} square metres");

Console.WriteLine($"The length of wood needed is: {woodLength} feet");
double height, width, glassArea, woodLength;

const double MIN_HEIGHT = 0.75;
const double MAX_HEIGHT = 3.0;
const double MIN_WIDTH = 0.5;
const double MAX_WIDTH = 5.0;

Console.WriteLine("Enter the height of the window in metres:");
height = double.Parse(Console.ReadLine()); 

if (height < MIN_HEIGHT)
{
    Console.WriteLine("Height is too small. /n/n");
    Console.WriteLine("Using minimum (0.75)");
    height = MIN_HEIGHT;
}

if (height > MAX_HEIGHT)
{
    Console.WriteLine("Height is too large. /n/n");
    Console.WriteLine("Using maximum (3.0)");
    height = MAX_HEIGHT;
}


Console.WriteLine("Enter the width of the window in metres:");
width = double.Parse(Console.ReadLine());

if (width < MIN_WIDTH)
{
    Console.WriteLine("Width is too small. /n/n");
    Console.WriteLine("Using minimum (0.5)");
    width = MIN_WIDTH;
}

if (width > MAX_WIDTH)
{
    Console.WriteLine("Width is too large. /n/n");
    Console.WriteLine("Using maximum (5.0)");
    width = MAX_WIDTH;
}

glassArea = 2 * (height * width);

woodLength = 2 * (height + width) * 3.25;

Console.WriteLine($"The area of the glass is: {glassArea} square metres");

Console.WriteLine($"The length of wood needed is: {woodLength} feet");

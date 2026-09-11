double height, width, glassArea, woodLength;

const double MIN_HEIGHT = 0.75;
const double MAX_HEIGHT = 3.0;
const double MIN_WIDTH = 0.5;
const double MAX_WIDTH = 5.0;

do
{
    Console.WriteLine($"Enter the height of the window between {MIN_HEIGHT} and {MAX_HEIGHT} metres:");
    height = double.Parse(Console.ReadLine());
    
} while (height < MIN_HEIGHT || height > MAX_HEIGHT);



do
{
    Console.WriteLine($"Enter the width of the window between {MIN_WIDTH} and {MAX_WIDTH} metres:");
    width = double.Parse(Console.ReadLine());
    
} while (width < MIN_WIDTH || width > MAX_WIDTH);

glassArea = 2 * (height * width);

woodLength = 2 * (height + width) * 3.25;

Console.WriteLine($"The area of the glass is: {glassArea} square metres");

Console.WriteLine($"The length of wood needed is: {woodLength} feet");

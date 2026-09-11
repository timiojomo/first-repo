int i = 150;
double f = 1234.56789;

// Using placeholders
Console.WriteLine("i:{0} f:{1}", i, f);

// Adjust Number Precision
Console.WriteLine("i: {0:0} f: {1:0.00}", i, f);

// Specify Digits to be printed
Console.WriteLine("i: {0:0000} f: {1: 0000.00}", i, f);

// Adding Commas
Console.WriteLine("i: {0: #,##0} f: {1: ##,##0.00}", i, f);

// Printing in Columns
Console.WriteLine("i: {0,10:0} f: {0,15:0.00}", i,f);
Console.WriteLine("i: {0,-10:0} f: {0,-15:0.00}", i,f);
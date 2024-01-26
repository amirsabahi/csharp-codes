// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// int a = 4;
// int b = 5;
// string result = a.ToString() + b.ToString();
// Console.WriteLine($"result  : {result}");

// string str = "123";
// int strNumber = int.Parse(str);
// Console.WriteLine($"result  : {strNumber}");
// string value = "5";
// string value2 = "7";

// int result2 = Convert.ToInt32(value) + Convert.ToInt32(value2);

// Console.WriteLine($"result  : {result2}");

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// string value = "oops";
// int result = 0;

// if(int.TryParse(value, out result)) {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
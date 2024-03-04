using System;

Console.WriteLine("Using doubls");
double a = 0.1;
double b = 0.2;

Console.WriteLine(a + b);

if(a+b == 0.3)
{
    Console.WriteLine("a+b equals 0.3");
}
else
{
    Console.WriteLine("a+b does not equal 0.3");
}

float c = 0.1F;
float d = 0.2F;

Console.WriteLine(c + d);

if(c+d == 0.3F)
{
    Console.WriteLine("c+d equals 0.3");
}
else
{
    Console.WriteLine("c+d does not equal 0.3");
}

decimal e = 0.1M;
decimal f = 0.2M;
Console.WriteLine(e + f);
if(e + f == 0.3M)
{
    Console.WriteLine("e+f equals 0.3");
}   
else
{
    Console.WriteLine("e+f does not equal 0.3");
}


int y = 5;

void print5()
{
    int y=6;
    Console.WriteLine(y);
}

print5();

var k = 5.0D;

Console.WriteLine($"{k} IS {typeof(double)}");

var j = 5.0F;

Console.WriteLine($"{j} IS {typeof(float)}");

var x = 5.0M;

Console.WriteLine($"{x} IS {typeof(decimal)}");

var z = 5L;
Console.WriteLine($"{z} IS {typeof(long)}");

var u = 5UL;
Console.WriteLine($"{u} IS {typeof(ulong)}");

var population= 5_000_000;
Console.WriteLine($"{population} IS {typeof(int)}");

uint m = int.MaxValue;
Console.WriteLine($"{m} IS {typeof(uint)}");

float n = float.MaxValue;
Console.WriteLine($"{n} IS {typeof(float)}");


// Game g = new();
// g.score = 1;


// class Game 
// {
//     public int score;
// }

// List<Player> player = new()
// {
//     new() { name = "John"},
//     new() { name = "Jack"},
//     new() { name = "Bob"},
//     new() { name = "Karl" }
// };
// class Player
// {
//     public string name;
// }

Console.WriteLine($"Default for float is {default(float)}");

string start = Console.ReadLine();
if(start.ToUpper() == "Y")
{
    Console.WriteLine("Let's play!");
}
else
{
    Console.WriteLine("Goodbye!");
}
Console.Write("Press any key combination: ");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);

string T = "5";
Console.WriteLine(int.Parse(T));
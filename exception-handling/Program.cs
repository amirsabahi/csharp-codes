using System;

checked
{
    try 
    {
        int sum1 = int.MaxValue;
        int sum2 = int.MaxValue;
        int result = sum1 + sum2;
        Console.WriteLine(result);
    } 
    catch(OverflowException e)
    {
        Console.WriteLine(e.Message);
    }
}

try
{
    string? name= null;
    int length = name.Length;
} 
catch (NullReferenceException e) 
{
    Console.WriteLine(e.Message);
}

try
{
    string[] array = new string[5];
    string  hello =array[5] ;
}
catch(IndexOutOfRangeException e) 
{
    Console.WriteLine(e.Message);
}

try
{
    int num1 = 10;
    int num2 = 0;
    int result = num1 / num2;
    Console.WriteLine(result);
}
catch(DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("This is the finally block");
}
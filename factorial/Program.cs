using System;
try
{
    uint result = factorial(100);
    WriteLine($"Factorial of 10 is {result}");
}
catch (ArgumentOutOfRangeException ex)
{
    WriteLine(ex.Message);
}
catch (OverflowException)
{
    WriteLine($"! is too big for a 32-bit integer.");
}
catch (Exception ex)
{
    WriteLine($" throws {ex.GetType()}: {ex.Message}");
}


static uint factorial(uint number)
{
    WriteLine($"Calculating factorial of {number}");
    if (number < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(number), "Number must be greater than or equal to 1");
    }
    else if (number == 0)
    {
        return 1;
    }
    else
    {
        checked
        {
            return number * factorial(number - 1);
        }
    }
}
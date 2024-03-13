using System;
RunFibo();

void RunFibo()
{
    for(uint i = 0; i<15; i++)
    {
        try{
        Console.WriteLine($"{CardinalToOrdinal(i)} number is {Fibonacci(i)}");
        }
        catch(ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"{i} is out of range.");
        }
    }
}

string CardinalToOrdinal(uint number)
{
    uint lastTwoDigit = number % 100;
    switch(lastTwoDigit)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
    }

    uint lastDigit = number % 10;
     string suffix = lastDigit switch
     {
        1 => "st",
        2=> "nd",
        3=> "rd",
        _=> "th"
     };
     return $"{number}{suffix}";
}

int Fibonacci(uint i) => i switch
{
    0=> throw new ArgumentOutOfRangeException(),
    1=> 0,
    2=> 1,
    _=>Fibonacci(i-1) + Fibonacci(i-2)
};

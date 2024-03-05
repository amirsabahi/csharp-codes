object score = 3;

if(score is int i) 
{
    Console.WriteLine($"The score is {i}");
}
else 
{
    Console.WriteLine("The score is not an integer");
}

string? actualPassword = "AAA";
string? expectedPass;

do{
    WriteLine("Enter your password: ");
    expectedPass = ReadLine();
} while(expectedPass != actualPassword);

WriteLine("Password accepted!");
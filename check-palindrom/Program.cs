

bool isPalinddrome(string str)
{
    int firstIndex = 0;
    int lastIndex = str.Length - 1;
    str = str.ToLower();
    while(firstIndex < str.Length/2)
    {
        if(str[firstIndex] != str[lastIndex])
        {
            return false;
        }
        firstIndex++;
        lastIndex--;
    } 
    return true;
}

if(isPalinddrome("Kayak"))
{
    Console.WriteLine("It is a palindrome");
}
else
{
    Console.WriteLine("It is not a palindrome");
}
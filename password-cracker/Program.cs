// See https://aka.ms/new-console-template for more information
using System;

void cracker()
{
    string[] characters = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                        "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                        "u", "v", "w", "x", "y", "z", "1", "2", "3", "4",
                                        "5", "6", "7", "8", "9", "0"};
    for (int i = 0; i < characters.Length; i++)
    {
        for (int j = 0; j < characters.Length; j++)
        {
            for (int k = 0; k < characters.Length; k++)
            {
                for (int l = 0; l < characters.Length; l++)
                {
                    string[] password = new string[] { characters[i], characters[j], characters[k], characters[l] };
                    Console.WriteLine(string.Join("", password));
                }
            }
        }
    }
}

cracker();

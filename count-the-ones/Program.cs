int[,] numbers = new int[,]
{
    {1, 0, 1, 1, 0, 1, 1, 1, 0, 0},
    {1, 0, 1, 1, 1, 0, 0, 1 ,1, 1},
    {1, 1, 1, 1, 0, 0, 0, 1, 1, 1},
    {1, 0, 1, 0, 0, 1, 1, 1, 0, 0},
    {1, 0, 1, 1, 0, 1, 1, 0, 1, 0},
    {0, 1, 1, 0, 1, 1, 1, 0, 0, 0},
    {0, 0, 0, 1, 1, 0, 1, 1, 0, 1},
    {1, 0, 1, 1, 0, 1, 0, 0, 0, 0},
    {1, 0, 1, 1, 0, 1, 1, 1, 0, 0},
    {1, 0, 0, 1, 1, 1, 0, 0, 1, 1},
};

for(int i=0; i<numbers.GetLength(0); i++)
{
    int count = 0;
    for(int j=0; j<numbers.GetLength(1); j++)
    {
        if(numbers[i, j] == 1)
        {
            count++;
        }
    }
    Console.WriteLine($"Row contains {count} ones");
}

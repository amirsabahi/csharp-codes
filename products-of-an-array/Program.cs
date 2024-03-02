using System;

List<int> GetAllProducts(int[] array)
{
    List<int> products = new List<int>();
    for(int i=0; i<array.Length; i++)
    {
        for(int j=i+1; j<array.Length; j++)
        {
            products.Add(array[i] * array[j]);
        }
    }
    return products;
}

List<int> result = GetAllProducts(new int[] {1, 2, 3, 4, 5});

foreach(int product in result)
{
    Console.WriteLine(product);
}
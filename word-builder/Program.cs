var array = WordBuilder.Build(new string[] { "a", "b", "c", "d" });
foreach(string word in array)
{
    Console.WriteLine(word);
}
class WordBuilder
{
    public static string[] Build(string[] array)
    {
        List<string> newArray = new List<string>();
        for(int i=0; i<array.Length; i++)
        {
            for(int j=0; j<array.Length; j++)
            {
                if(i!=j)
                {
                    newArray.Add(array[i] + array[j]);
                }
            }
        }    
        return newArray.ToArray();
    } 
}

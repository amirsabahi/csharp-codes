public class Program
{
    public static void Main(string[] args)
    {
        maxProductDifference();
    
    }
private static void maxProductDifference() 
    {
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int[] nums = new int[] {7,8,2,9};
        foreach(int num in nums)
        {
            if(num <= min1)
            {
                min2 = min1;
                min1= num;
            } else if (num < min2) 
            {
                min2 = num;
            }

            if(num >= max1)
            {
                max2 = max1;
                max1= num;
            } else if (num > max2) 
            {
                max2 = num;
            }
        }

        int product = (max1 * max2) - (min1 * min2);
        Console.WriteLine(product);
    }
}

int[] res = Solution.Merge(new int[] { 1, 2, 3, 10, 12, 14 }, new int[] { 2, 5, 6, 13, 14 });
foreach (var item in res)
{
    Console.WriteLine(item);
}
class Solution
{
    public static int[] Merge(int[] nums1, int[] nums2)
    {
        int i = 0;
        int j = 0;
        int k = 0;
        int num1Length = nums1.Length;
        int num2Length = nums2.Length;
        int[] result = new int[num1Length + num2Length];

        while (i < num1Length && j < num2Length)
        {
            if (nums1[i] < nums2[j])
            {
                result[k] = nums1[i];
                i++;
            }
            else
            {
                result[k] = nums2[j];
                j++;


            }
            k++;
        }

        while (i < num1Length)
        {
            result[k] = nums1[i];
            i++;
            k++;
        }

        while (j < num2Length)
        {
            result[k] = nums2[j];
            j++;
            k++;
        }
        return result;
    }


}



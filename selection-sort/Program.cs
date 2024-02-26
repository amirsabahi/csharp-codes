


    int[] sortedArray = Sort.selectionSort(new int[] { 5, 3, 4, 1, 2 });
    foreach (int value in sortedArray)
    {
        Console.WriteLine(value);
    }
    class Sort
    {
        public static int[] selectionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int tempValue = array[i];
                int position = i - 1;
                while (position >= 0)
                {
                    if (array[position] > tempValue)
                    {
                        array[position + 1] = array[position];
                        position--;
                    }
                    else
                    {
                        break;
                    }
                }
                array[position + 1] = tempValue;
            }
            return array;
        }
    }




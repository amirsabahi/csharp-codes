// See https://aka.ms/new-console-template for more information∂

public class HashTable
{
    private object[] HashTableArray;
    public HashTable(int size)
    {
        HashTableArray = new object[size];
    }

    private int _Hash(string key)
    {
        int Hash = 0;
        for (int i = 0; i < key.Length; i++)
        {
            Hash = (Hash + key[i] * i) % HashTableArray.Length;
        }
        return Hash;
    }

    public void set(string Key, object value)
    {
        HashTableArray[_Hash(Key)] = value;
    }

    public object get(string Key)
    {
        return HashTableArray[_Hash(Key)];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HashTable hashTable = new HashTable(50);
        hashTable.set("Amir", 420);
        object result = hashTable.get("Amir");

        System.Console.WriteLine(result);
    }
}

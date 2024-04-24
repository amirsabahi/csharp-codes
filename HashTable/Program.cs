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
        int hashKey = _Hash(Key);
        if (HashTableArray[hashKey] == null)
            HashTableArray[hashKey] = new List<object[]>();
        var list = (List<object[]>)HashTableArray[hashKey];
        list.Add(new object[] { Key, value });
    }

    public object get(string Key)
    {
        var list = (List<object[]>)HashTableArray[_Hash(Key)];
        foreach (var item in list)
        {
            if (item[0] == Key)
                return item[1];
        }
        return false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HashTable hashTable = new HashTable(50);
        hashTable.set("Amir", 420);
        hashTable.set("Ami", 658);
        hashTable.set("Amer", 654);

        object result = hashTable.get("Ami");


        System.Console.WriteLine(result);
    }
}

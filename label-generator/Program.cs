string[] listOfClothes = new string[] {
    "t-shirts", "sweatshirts", "pants", "shorts", "dresses", "skirts", 
    "blouses", "suits", "jackets", "coats", "hats", "gloves", 
    "scarves", "socks", "shoes", "boots", "slippers", "sandals",    
};

foreach(string item in listOfClothes)
{
    for(int size=1; size<6; size++)
    {
        Console.WriteLine($"{size} {item}");
    }
    
}

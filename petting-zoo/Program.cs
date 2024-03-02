using System;

string[] pettingZoo = {
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);


void PlanSchoolVisit(string schoolName, int group=6)
{
    RandomizeAnimals();
    string[,] group1 = AssignGroup(group);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

void RandomizeAnimals()
{
    Random random = new Random();
    for(int i=0; i<pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);
        string temp= pettingZoo[i];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

string [,] AssignGroup(int groups = 6)
{
    string [,]  result = new string[groups, pettingZoo.Length/groups];
    int start = 0;
    for(int i=0; i<groups; i++)
    {
        for(int j=0; j<result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
        
    }
    return result;
}

void PrintGroup(string[,] groups)
{
    for(int i=0; i<groups.GetLength(0); i++)
    {
        Console.WriteLine($"Group {i+1}");
        for(int n=0; n<groups.GetLength(1); n++)
        {
            Console.WriteLine(groups[i, n]);
        }
        Console.WriteLine();
    }
}
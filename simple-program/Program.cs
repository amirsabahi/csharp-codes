double c = 9.8;
int d = (int)c; // Compiler gives an error if you do not explicitly cast.
WriteLine($"c is {c}, d is {d}");
double g=9.8;
int h = Convert.ToInt32(g); // Convert.ToInt32 rounds the number to the nearest whole number.
WriteLine($"g is {g}, h is {h}");

bool success = Uri.TryCreate("https://localhost:5000/api/customers", UriKind.Absolute, out Uri serviceUrl);

WriteLine($"Success: {serviceUrl.ToString()}");

// string[][] jaggedArray = 
// {
//     new[] {"apple", "banana", "cherry", "date"},
//     new[] {"elderberry", "fig", "grape", "honeydew"},
//     new[] {"jujube", "kiwi", "lemon", "mango"}
// };

// for(int i = 0; i <= jaggedArray.GetUpperBound(0); i++)
// {
//     WriteLine($"Processing array {i}");
//     for(int j = 0; j < jaggedArray[i].Length; j++)
//     {
//         WriteLine($"   Processing item {j}");
//         WriteLine($"      {jaggedArray[i][j]}");
//     }
// }
// string[,] a2Darray = 
// {
//     {"apple", "banana", "cherry", "date"},
//     {"elderberry", "fig", "grape", "honeydew"},
//     {"jujube", "kiwi", "lemon", "mango"}
// };

// for(int i=0; i<a2Darray.GetLength(0); i++)
// {
//     WriteLine($"Processing array {i}");
//     for(int j=0; j<a2Darray.GetLength(1); j++)
//     {
//         WriteLine($"   Processing item {j}");
//         WriteLine($"      {a2Darray[i,j]}");
//     }
// }


// object score = 3;

// if(score is int l) 
// {
//     Console.WriteLine($"The score is {l}");
// }
// else 
// {
//     Console.WriteLine("The score is not an integer");
// }

// string? actualPassword = "AAA";
// string? expectedPass;

// do{
//     WriteLine("Enter your password: ");
//     expectedPass = ReadLine();
// } while(expectedPass != actualPassword);

// WriteLine("Password accepted!");
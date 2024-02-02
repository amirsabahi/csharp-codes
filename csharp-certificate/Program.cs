string[] scores = {"B12", "B10", "A2", "A1", "B11", "A10", "A12", "B1", "B13", "A11"};
Array.Sort(scores);
foreach (string score in scores)
{
    Console.WriteLine($"-- {score}");
}
Console.WriteLine($"-- ------------------");
Array.Reverse(scores);

foreach (string score in scores)
{
    Console.WriteLine($"-- {score}");
}

Console.WriteLine($"-- ------------------");
Array.Clear(scores,0,8);
foreach (string score in scores)
{
    Console.WriteLine($"-- {score}");
}
Console.WriteLine($"-- ------------------");
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]?.ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]?.ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Resize(ref pallets, 8);
Console.WriteLine($"-- ------------------");

pallets[7]= "abc";
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Resize(ref pallets,2);

Console.WriteLine($"-- ------------------");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine($"-- ------------------");

string playerName = "Steph";
char[] nameArray = playerName.ToCharArray();
Console.WriteLine($"-- {nameArray[4]}");
Array.Reverse(nameArray);
Console.WriteLine($"-- {nameArray[0]}");
string reverseName = new  string(nameArray);
Console.WriteLine($"-- {reverseName}");
Array.Reverse(nameArray);
string reversedNameString  = String.Join(',', nameArray);

Console.WriteLine($"-- {reversedNameString}");

string[] splittedName = reversedNameString.Split(',');
foreach(string item in splittedName) {
    Console.WriteLine($"-- {item}");
}


string pangram = "The quick brown fox jumps over the lazy dog";

char[] pangramChars = pangram.ToCharArray();
Array.Reverse(pangramChars);
string reversePangram = new string(pangramChars);
Console.WriteLine($"-- {reversePangram}");

string[] pangramWords = pangram.Split(' ');
for(int i=0; i< pangramWords.Length; i++) {
    char[] reverseWordsChars = pangramWords[i].ToCharArray();
    Array.Reverse(reverseWordsChars);
    pangramWords[i] = new string(reverseWordsChars);
}
string reversedwords = string.Join(' ', pangramWords);
Console.WriteLine($"-- {reversedwords}");

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIdsArray = orderStream.Split(',');

foreach(string order in orderIdsArray) {
    if (order.Length != 4) {
        Console.WriteLine($"-- Invalid order id: {order}");
    }
    Console.WriteLine($"-- Valid order id: {order}");
}

decimal tax = 1.8485m;
int price = 99;
Console.WriteLine($"tax:{tax:N3} Price is: {price:C}");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

 string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));
  Console.WriteLine(input.PadRight(12, '_'));

  string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine(formattedLine);
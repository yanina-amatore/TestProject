/*int[] inventory = {200,450,700,175,250};

int sum = 0;
int bin=0;

foreach (int items in inventory)
{
  sum+=items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
};

Console.WriteLine($"We have {sum} items in inventory.");*/

/*
string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string name in orderIDs)
{
  if ( name.StartsWith('B'))
  {
    Console.WriteLine($"The name {name} starts with 'B'");
  }

}*/

/*Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{

    int prefixValue = random.Next(65, 70);  
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
 
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}*/

string str = "The quick brown fox jumps over the lazy dog.";


char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int letter = 0;

foreach (char i in charMessage) 
{ 
  if (i == 'o')
   { 
    letter++;
   } 
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letter} times.");
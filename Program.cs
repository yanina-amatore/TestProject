/* -- PROJECT 1

string? readResult;
bool validEntry = false;

int numericValue = 0;
bool validNumber = false;

//validNumber = int.TryParse(readResult, out numericValue);

Console.WriteLine("Enter a  number between 5-10");

do
{
    readResult = Console.ReadLine();    
    
    validNumber = int.TryParse(readResult, out numericValue);

    if (readResult != null)
    {
        if (numericValue >= 5 && numericValue <=10)
        {
          Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
            validEntry = true;

        }
        else
        {
            Console.WriteLine($"Your input ({numericValue}) is invalid, please try again a number between 5-10 .");
        }
    }
} while (validEntry == false);
*/
/* -- PROJECT 2 
string? readResult;
bool validEntry = false;


Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
   readResult = Console.ReadLine()?.Trim().ToLower();
  
    if (readResult != null)
    {
      
        if (readResult == "administrator" || readResult == "manager" || readResult == "user")
        {
            Console.WriteLine($"Your role ({readResult}) has been accepted.");
            validEntry = true;
        }
        else
        {
            Console.WriteLine($"Your role ({readResult}) is invalid, please try again (Administrator, Manager, or User).");
        }
    }
} while (validEntry == false); */

/* -- PROJECT 3 */
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
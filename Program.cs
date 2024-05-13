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

/* -- PROJECT 2 */
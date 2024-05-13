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
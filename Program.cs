/*Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());*/

/*Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));*/

// These two lines of code will create the same output

/*string pangram = "The quick brown fox jumps over the lazy dog.";

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));


int saleAmount = 99;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");*/

/*Random coin = new Random();

int flip = coin.Next(0, 2);

Console.WriteLine(flip == 0 ? "Heads" : "Tails");*/

string permission = "Manager";
//string permission = "Admin|Manager";
int level = 19;
string message = "";

/* To sufficiently test all of the combinations for permission and level that are described in the business rules below, you will need to assign additional values to these variables and run the application multiple times. */


//  Admin > 55 Welcome, Super Admin user.
//  Admin <= 55 Welcome, Admin user.
//  Manager >= 20 Contact an Admin for access.
//  Manager < 20 You do not have sufficient privileges.
//  ! Admin or a Manager You do not have sufficient privileges.


if (permission.Contains("Admin") && level > 55){

  message = "Welcome, Super Admin user.";

} else if (permission.Contains("Admin") && level <= 55){

   message = "Welcome, Admin user.";

} else if (permission.Contains("Manager") && level >= 20){

   message = "Contact an Admin for access.";

} else if (permission.Contains("Manager") && level < 20){

  message ="You do not have sufficient privileges.";

} else if (!permission.Contains("Admin") && !permission.Contains("Manager")){

  message ="You do not have sufficient privileges.";
}


Console.WriteLine( message );



Console.WriteLine(

    permission.Contains("Admin") && level > 55 ? "Welcome, Super Admin user." :
    permission.Contains("Admin") && level <= 55 ? "Welcome, Admin user." :
    permission.Contains("Manager") && level >= 20 ? "Contact an Admin for access" :
    permission.Contains("Manager") && level < 20 ? "You do not have sufficient privileges." :
    !permission.Contains("Manager") || !permission.Contains("Admin") ? "You do not have sufficient privileges" : ""
);


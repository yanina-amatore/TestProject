
/*for (int i = 0; i < 10; i++) 
{
  Console.WriteLine(i);
      if (i == 7) break;
}; */


/*string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0 ; i <= names.Length - 1; i++)
{
    Console.WriteLine(names[i]);
};

foreach (string name in names){
  if( name == "David" ) name = "Sammy";
};

for ( int i = 0; i <= names.Length -1; i++){
  if( names[i] == "David" ) names[i] = "Sammy";
  Console.WriteLine(names[i]);
}; */

/* FizzBuzz challenge

- Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
- When the current value is divisible by 3, print the term Fizz next to the number.
- When the current value is divisible by 5, print the term Buzz next to the number.
- When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

*/
for (int i = 1; i <= 100; i++)
{
  if (i % 3 == 0 && i % 5 == 0)
  {
    Console.WriteLine(i + " FizzBuzz");
  }
  else if (i % 3 == 0)
  {
    Console.WriteLine(i + " Fizz");
  }
  else if (i % 5 == 0)
  {
    Console.WriteLine(i + " Buzz");
  }
  else
  {
    Console.WriteLine(i);
  }
};
  
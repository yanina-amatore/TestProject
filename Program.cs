/*bool flag = false;

 int value = 2;
if (flag)
{
   value = 10;
  Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");*/


 /*A developer writes some code that includes an if statement code block.
  They initialize one integer variable to a value of 5 above (outside) of the code block. T
  hey initialize a second integer variable to a value of 6 on the first line inside of the code block.
  The Boolean expression for the code block evaluates to true if the first integer variable has a value greater than 0. 
  On the second line inside the code block, they assign the sum of the two values to the first variable.
   On the first line after the code block, they write code to display the value of the first integer. What is the result when the code statement used to display the first integer is executed? */

/*int value = 5;

if( value > 0 ){

  int value2 = 6;
  value+= value2;
}

Console.WriteLine(value); */

/*string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck"); */

/*int[] numbers = { 4, 8, 15, 16, 23, 42 };


bool found = false;

int total = 0;

foreach (int number in numbers)
{
    total += number;
    if (number == 42) found = true;

}

if (found)  Console.WriteLine("Set contains 42");
Console.WriteLine($"Total: {total}");*/

/*2. A developer writes some code that includes an if statement code block. 
They initialize a first integer variable to a value of 1 above (outside) of the code block. 
The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. 
The first code line inside of the code block is used to initialize a second integer variable to a value of 8. The second code line inside the code block is used to assign the sum of the two integer values to the first variable. 
The first code line after the code block is used to display the value of the first integer variable. What is the result when the code is executed? 

int var1 =1;

if (var1>0)
{
int var2 = 8;

var1 += var2;

}

Console.WriteLine($"Total: {var1}");*/

/*3. A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 5 above (outside) of the code block. The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. The first code line inside of the code block is used to initialize a second integer variable to a value of 6. The first code line after the code block is used to add the second integer value to the value of the first integer. The second code line after the code block is used to display the value of the first integer. What is the result when they run the code? */

int var1 =5;

if (var1>0)
{
int var2 = 6;

}
var2 += var1;
Console.WriteLine($"Total: {var1}");

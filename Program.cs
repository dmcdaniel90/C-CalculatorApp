using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Welcome to the C# Calculator Console App. Press any key to continue...");
Console.ReadKey();

//Declare variables
bool calculating = true;
float baseValue;
float value2;
string? input1;
string? input2;

//Input value 1 and check if valid
Console.WriteLine("Enter a number");
input1 = Console.ReadLine();

if (float.TryParse(input1, out baseValue))
{
  baseValue = float.Parse(input1);
}
else
{
  Console.WriteLine("Invalid input. Please enter a valid number.");
  return;
}

while(calculating) 
{

  //Choose an operator
  Console.WriteLine("Enter an operator: Add +, Subtract -, Multiply *, Divide /");
  string? oper = Console.ReadLine();

  //Input value 2 and check if valid
  Console.WriteLine("Enter another number");
  input2 = Console.ReadLine();

  if (float.TryParse(input2, out value2))
  {
    value2 = float.Parse(input2);
  }
  else
  {
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
  }

  //Calculate result and reassign base
  switch(oper) {
    case "+":
      baseValue = baseValue + value2;
      Console.WriteLine($"Result: {baseValue}");
      break;
    case "-":
      baseValue = baseValue - value2;
      Console.WriteLine($"Result: {baseValue}");
      break;
    case "*":
      baseValue = baseValue * value2;
      Console.WriteLine($"Result: {baseValue}");
      break;
    case "/":
      baseValue = baseValue / value2;
      Console.WriteLine($"Result: {baseValue}");
      break;
    default:
      Console.WriteLine("You entered an invalid operator");
      break;
  }

  //Prompt user to continue
  Console.WriteLine("Would you like to continue?");
  string? res = Console.ReadLine();

  switch(res) {
    case "yes":
      break;
    case "y":
      break;
    default:
      calculating = false;
      Console.WriteLine($"Final result is {baseValue}");
      break;
  }
}

Console.WriteLine("Exiting application");









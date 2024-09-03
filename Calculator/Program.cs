// See https://aka.ms/new-console-template for more information

int num1;
int num2;
int result;


Console.WriteLine("Enter the first number:");
 string input1 = Console.ReadLine();
 int.TryParse(input1, out  num1);

Console.WriteLine("Enter the second number:");
 string input2 = Console.ReadLine();
int.TryParse(input2, out num2);
Console.WriteLine("Choose an operation: +, -, *, /");
  string input3 = Console.ReadLine();

switch (input3)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine($"Result: {result}");
        break;
        case "-":
        result = num1 - num2;
        Console.WriteLine($"Result: {result}");
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine($"Result: {result}");
        break;
    case "/":
        if (num2 > 0) 
        {  result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }
        else { Console.WriteLine("Error: Division by zero is not allowed."); }
        break;
    default:
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
        break;


}
Console.ReadKey();

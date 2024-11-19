// 1. Calculator:
Console.Write("First Number :");
decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter the character(+, -, *, /) :");
char character = Convert.ToChar(Console.ReadLine());
Console.Write("Second Number :");
decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
decimal result = 
character == '-' ? firstNumber - secondNumber :
character == '+' ? firstNumber + secondNumber :
character == '/' ? firstNumber / secondNumber :
firstNumber * secondNumber;
Console.WriteLine(result);

// 2. Calculating the sum of a number sequence:
Console.Write("N = ");
ulong number = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine($"Result : {(number * (number + 1) / 2)}");

// 3. Parity check:
Console.Write("Enter the number =");
long numberr = Convert.ToInt64(Console.ReadLine());
Console.WriteLine(numberr % 2 == 0 ? "Juft son" : "Toq son");

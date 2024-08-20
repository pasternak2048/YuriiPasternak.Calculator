using YuriiPasternak.Calculator.Interfaces;
using YuriiPasternak.Calculator.Models;

System.Globalization.CultureInfo customCulture 
    = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

Console.WriteLine(@"CALCULATOR.
This calculator provides basic arithmetic operations ( + - * / ).

INSTRUCTION.

Firstly, enter the first number in a specified format: ( 1 || 1234 || 1.234 || 123.456 ).

Secondly, enter the second number in a specified format: ( 1 || 1234 || 1.234 || 123.456 ).

Then, enter the operation sign: ( + - * / ).

Finally, get result.

Important: you are not allowed to divide by zero.

Good Luck!
");



double a, b, result = 0;

// ENTERING OF THE FIRST NUMBER
Console.Write("Enter the first number: ");

string inputA = Console.ReadLine();
while (!double.TryParse(inputA, out a))
{
    Console.Write(@"ERROR: NUMBER HAS TO BE NUMERIC ONLY. TRY AGAIN.

Enter the first number: ");

    inputA = Console.ReadLine();
}


// ENTERING OF THE SECOND NUMBER
Console.Write("Enter the second number: ");

string inputB = Console.ReadLine();

while (!double.TryParse(inputB, out b))
{
    Console.Write(@"ERROR: NUMBER HAS TO BE NUMERIC ONLY. TRY AGAIN.

Enter the second number: ");

    inputB = Console.ReadLine();
}


// ENTERING OF THE OPERATION SIGN
Console.Write("Enter the operation sign: ");

string inputOperation = Console.ReadLine();

while (inputOperation !="+"
    && inputOperation != "-"
    && inputOperation != "*"
    && inputOperation != "/")
{
    Console.Write(@"ERROR: YOU HAVE TO USE ONLY   (+ - * /)   SIGNS. TRY AGAIN.

Enter the operation sign: ");
    inputOperation = Console.ReadLine();

}

while (
    inputOperation != "+"
    && inputOperation != "-"
    && inputOperation != "*" && b == 0)
{
    Console.Write(@"ERROR: YOU ARE NOT ABLE TO DIVIDE FOR ZERO.

Choose another operator: (+ - *): ");
    inputOperation = Console.ReadLine();
}



// CALCULATING
ICalculator<double> calculatorDouble = new CalculatorDouble();
CalculatorHandler<double>.Calculate(a, b, inputOperation, calculatorDouble, out result);

// RESULT
Console.WriteLine();
Console.WriteLine($"RESULT: {a} {inputOperation} {b} = {result}");
Console.ReadKey();

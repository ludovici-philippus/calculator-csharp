using System;
using System.Linq;


class Calculator {
  static private Calculator calc = new Calculator();

  static void Main(string[] args) {
    Console.WriteLine("Type the first number: ");
    float num1 = calc.getNumber();

    Console.WriteLine("Type the second number: ");
    float num2 = calc.getNumber();

    Console.WriteLine("Great! Now type the operation: [+, -, *, /]");
    string operation = Console.ReadLine();

    if (!calc.isAllowedOperation(operation)) { Console.WriteLine("Operation not allowed!"); return; }
    Console.WriteLine($"{num1} {operation} {num2} = {calc.calculate(num1, num2, operation)}");
  }

  float getNumber() { return float.Parse(Console.ReadLine()); }

  float calculate(float num1, float num2, string operation) {
    if (operation == "+")  return calc.sum(num1, num2);
    else if (operation == "-") return calc.sub(num1, num2);
    else if (operation == "*") return calc.multiply(num1, num2);
    return calc.div(num1, num2);
  }

  float sum(float num1, float num2) { return num1 + num2; }
  float sub(float num1, float num2) { return num1 - num2; }
  float div(float num1, float num2) { return num1 / num2; }
  float multiply(float num1, float num2) { return num1 * num2; }

  bool isAllowedOperation(string operation) {
    string[] allowed_operations = { "+", "-", "*", "/" };

    return allowed_operations.Contains(operation);
  }
}

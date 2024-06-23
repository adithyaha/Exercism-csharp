using System;
using System.Numerics;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        switch(operation)
        {
            case "+":
                return $"{operand1} + {operand2} = {SimpleOperation.Addition(operand1, operand2)}";
                break;
            case "*":
                return $"{operand1} * {operand2} = {SimpleOperation.Multiplication(operand1, operand2)}";
                break;
            case "/":
                if (operand2 == 0)
                {
                    return ("Division by zero is not allowed.");
                }
                return $"{operand1} / {operand2} = {SimpleOperation.Division(operand1, operand2)}";
                break;
            case "":
                throw new ArgumentException();
                break;
            case null:
                throw new ArgumentNullException();
                break;
            default:
                throw new ArgumentOutOfRangeException();
                break;
        }
    }
}

using System;
public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        int res = 0;

        if(operation == null)
        {
            throw new ArgumentNullException("Operador nulo", "operation");
        }else if(operation == "")
        {
            throw new ArgumentException("Operador vacio", "operation");
        }
        if(operation == "+")
        {
            res = operand1 + operand2;
            return $"{operand1} {operation} {operand2} = {res}";
        }else if(operation == "*")
        {
            res = operand1 * operand2;
            return $"{operand1} {operation} {operand2} = {res}";
        }else if(operation == "/")
        {
            if(operand2 == 0)
            {
                return "Division by zero is not allowed.";
            }
            res = operand1 / operand2;
            return $"{operand1} {operation} {operand2} = {res}";
        }else if(operation == "-")
        {
            throw new ArgumentOutOfRangeException("operation", $"Operador {operation} no esta permitido");
        }
        else
        {
            throw new ArgumentOutOfRangeException("operation", "Operacion no reconocida.");
        }
    }
}

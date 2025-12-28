using System;

class CalculatorLogic
{
    private static bool isDigit(char c)
    {
        if ((c >= '0' && c <= '9') || c == '.')
            return true;
        else
            return false;
    }

    private static bool isOperator(char c)
    {
        if (c == '+' || c == '-' || c == '*' || c == '/')
            return true;
        else
            return false;
    }

    private static double parseNumber(string equation, ref int index)
    {
        if (index >= equation.Length)
        {
            Console.WriteLine("No number after Operator");
            Environment.Exit(1);
        }

        if (equation[index] == '(')
        {
            index++;
            double result = parseEquation(equation, ref index);

            if (index >= equation.Length || equation[index] != ')')
            {
                Console.WriteLine("No closing bracket");
                Environment.Exit(1);
            }
                
            index++; 
            return result;
        }

        string buffer = "";

        while (index < equation.Length && isDigit(equation[index]))
        {
            buffer += equation[index];
            index++;
        }

        if (string.IsNullOrEmpty(buffer))
        {
            Console.WriteLine("Left or Right term is improper");
            Environment.Exit(1);
        }

        return double.Parse(buffer);
    }

    private static double parseTerm(string equation, ref int index)
    {
        double result = parseNumber(equation, ref index);

        while (index < equation.Length)
        {
            if (index >= equation.Length) break;
            char op = equation[index];

            if (op == '*' || op == '/')
            {
                index++;
                double nextTerm = parseNumber(equation, ref index);
                result = op == '*' ? result * nextTerm : result / nextTerm;
            }
            else break;

        }
        
        return result;
    }

    public static double parseEquation(string equation, ref int index)
    {
        double result = parseTerm(equation, ref index);

        while (index < equation.Length)
        {
            if (index >= equation.Length) break;
            char op = equation[index];

            if (op == '+' || op == '-')
            {
                index++;
                double nextTerm = parseTerm(equation, ref index);
                result = op == '+' ? result + nextTerm : result - nextTerm;
            }
            else break;
        }

        return result;
    }
}
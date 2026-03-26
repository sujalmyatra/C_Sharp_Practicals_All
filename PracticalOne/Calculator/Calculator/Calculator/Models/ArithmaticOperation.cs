namespace Calculator.Models;

static class ArithmaticOperation
{
    public static double Addition(double a, double b)
    {
        return a + b;
    }
    public static double Subtraction(double a, double b)
    {
        return a - b;
    }
    public static double Multiplication(double a, double b)
    {
        return a * b;
    }
    public static double Division(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot Divide By Zero");
        return a / b;
    }
}


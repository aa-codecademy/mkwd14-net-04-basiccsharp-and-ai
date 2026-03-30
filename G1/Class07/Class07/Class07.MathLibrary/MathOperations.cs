namespace Class07.MathLibrary;

public static class MathOperations
{
    public const double PI = 3.14;

    public static double Sum(double a, double b)
    {
        return a + b;
    }

    public static double Diff(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if(b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero! Please enter valid value!");
        }
        return a / b;
    }
}

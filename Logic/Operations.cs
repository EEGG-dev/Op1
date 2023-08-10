namespace Logic;

public static class Operations
{
    public static void sum()
    {
        double num1 = LogicMult.GetNumber(); 
        double num2 = LogicMult.GetNumber();
        System.Console.WriteLine(num1 + num2);
    }

    public static void Rest()
    {
        double num1 = LogicMult.GetNumber();
        double num2 = LogicMult.GetNumber();
        System.Console.WriteLine(num1 - num2);
    }

    public static void Mult()
    {
        double num1 = LogicMult.GetNumber();
        double num2 = LogicMult.GetNumber();
        System.Console.WriteLine(num1 * num2);
    }

    public static void Div()
    {
        double num1 = LogicMult.GetNumber();
        double num2 = LogicMult.GetNumber();
        System.Console.WriteLine(num1 / num2);
    }
}

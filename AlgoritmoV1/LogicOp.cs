using System.Diagnostics.CodeAnalysis;

namespace Logic;

public static class LogicMult
{
   public static void WelcomeMessage()
   {
        System.Console.WriteLine("WELCOME TO SWITCH APP");
        System.Console.WriteLine("*********************");
        System.Console.WriteLine();
   }

   public static double GetNumber()
   {
        bool isValidNumber;
        double num;
        do
        {
            System.Console.Write("Enter a number: ");
            string numberText = Console.ReadLine();
            isValidNumber = double.TryParse(numberText, out num);
            System.Console.WriteLine();
        } while (isValidNumber == false);
        return num;
   }

   public static char GetOperator()
   {
        System.Console.WriteLine("Enter the sign of the operation to be performed: ");
        char? sign = char.Parse(Console.ReadLine());
        return (char)sign;
   }

   public static void EvaluateSign(char sign)
   {
        switch(sign)
        {   
            case '+':
               Operations.sum();
               break;
            case '-':
               Operations.Rest();
               break;
            case '*':
               Operations.Mult();
               break;
           case '/':
               Operations.Div();
               break;
           default:
               System.Console.WriteLine("Operador aritmetico no valido.");
               break;

        }
        

   }
}

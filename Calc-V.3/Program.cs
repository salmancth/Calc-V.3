using System;

class Program

{
    static void Main(string[] args)

    {

        
        string a = string.Empty;
        do
        {
            Console.WriteLine("*** Welcome *** \n\nThis is basic calculator. \nGive your input : ");
            float number1 = (int)Convert.ToSingle(Console.ReadLine());
            float number2 = (int)Convert.ToSingle(Console.ReadLine());
            Console.Write("\nWhat do you want to do? (+, -, /, *, %): ");

            string operand = Console.ReadLine();

            switch (operand)
            {
                case "+":
                    Console.WriteLine("Answer: " + Add(number1, number2));
                    break;
                case "-":
                    Console.WriteLine("Answer: " + Minus(number1, number2));
                    break;
                case "*":
                    Console.WriteLine("Answer: " + Mult(number1, number2));
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        
                    }

                    Console.WriteLine("Answer: " + Div(number1, number2));

                    break;

                default:
                    Console.WriteLine("Please input again");
                    break;
            }



            Console.Write("\n\nPress C to contniue or  press any button to Stop )");
            
        }
        while (Console.ReadLine().ToUpper() == "C");
        Console.WriteLine("");
        Console.ReadKey();
        
    }


    public static float Add(float number1, float number2)
    {
        return number1 + number2;
    }
    public static float Minus(float number1, float number2)
    {
        return number1 - number2;
    }
    public static float Mult(float number1, float number2)
    {
        return number1 * number2;
    }
    public static double Div(double number1, double number2)
    {
        if (number2 != 0)
        {
            return number1 / number2;


        }
        else
            Console.WriteLine("Please input Non-zero value");
        return 0;

    }
}
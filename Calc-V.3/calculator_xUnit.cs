using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_xUnit
{
    public class Calculator_X
    {
        double Add;
        double Minus;
        double Mult;
        double Div;
        double Answer;

        double number1;
        double number2;

        double usernumber1;
        double usernumber2;

        util = new Utils();


        userNumber1 = (utils).Convert.ToDouble(number1);
        userNumber2 = (utils).Convert.ToDouble(number2);


        
        public void Add()
        {

            try
            {
                Console.WriteLine("Enter two number to add");
                Console.WriteLine("First number:")
                number1 = Console.ReadLine();
                
                Console.WriteLine("Second number: ");
                number2 = Console.ReadLine();
                
                Answer = utils.AddUp(userNumber1, userNumber2);
                utils.Result(Answer);
            }
            catch (Exception ex)
            {
                utils.CatchWarrning();
            };

        }
// --------------------------------------------------------------------
        public void Minus()
        {

            try
            {
                Console.WriteLine("Enter two number to substruct");
                Console.WriteLine("First number:")
                number1 = Console.ReadLine();
                
                Console.WriteLine("Second number: ");
                number2 = Console.ReadLine();
                
                Answer = utils.Minus(userNumber1, userNumber2);
                utils.Result(Answer);
            }
            catch (Exception ex)
            {
                utils.CatchWarrning();
            };

// -------------------------------------------------------------------------

        public void Mult()
        {

            try
            {
                    Console.WriteLine("Enter two number to Multiply");
                    Console.WriteLine("First number:")
                    number1 = Console.ReadLine();

                    Console.WriteLine("Second number: ");
                    number2 = Console.ReadLine();

                    Answer = utils.Mult(userNumber1, userNumber2);
                    utils.Result(Answer);
                }
                catch (Exception ex)
                {
                    utils.CatchWarrning();
                };

//--------------------------------------------------------------------------------
            public void Div()
            {

                try
                
                {
                    Console.WriteLine("Enter two number to Devide");
                    Console.WriteLine("First number:")
                    number1 = Console.ReadLine();
                
                    Console.WriteLine("Second number: ");
                    number2 = Console.ReadLine();
                
                    Answer = utils.Div(userNumber1, userNumber2);
                    utils.Result(Answer);
                }
                catch (Exception ex)
                {
                    utils.CatchWarrning();
                };

            
            }

        }

    }
}

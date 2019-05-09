using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                string choice;
                double a, b, num3=0;
                Console.WriteLine("enter the num1:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the num2:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the operation/choice u want like '*','-','+','%','/' :");

                Console.WriteLine("ans is:" +getRes(a, b));

                double getRes(double num1, double num2)
                {

                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "%":
                            num3 = num1 + num2;
                            break;
                        case "/":
                            num3 = num1 / num2;
                            break;
                        case "*":
                            num3 = num1 * num2;
                            break;
                        case "-":
                            num3 = num1 - num2;
                            break;
                        case "+":
                            num3 = num1 + num2;
                            break;
                    }

                    return num3;
                }
              //  Console.WriteLine(num3);
                Console.WriteLine("wants to continue:yes or no:");
                response=Console.ReadLine();
            } while (response == "yes");
        }
    }
}

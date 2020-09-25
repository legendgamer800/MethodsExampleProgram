using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            Console.ForegroundColor = ConsoleColor.White;
            while(choice.ToLower() !="q")
            {
                choice = Menu();
                switch (choice[0]) //only check the first charcater of the string
                {
                    case '1': //note how when we use characters its single quotes not double quotes!
                        // area of square
                        
                        double width  = GetDoubleNumber("Enter Width (cm):");
                        double height = GetDoubleNumber("Enter Height cm):");
                        Console.WriteLine("Area is {0} cm2",RectangleArea(width, height));
                        break;
                    case '2':
                        //perimeter of square

                        Console.WriteLine("Enter the length of one side.")
                        double SquareLength =
                        Console.WriteLine("The perimeter is {0} cm", SquarePerimeter(SquareLength))
                        break;
                    case '3':
                        //area of circle
                        break;
                    case '4':
                        //perimeter of circle
                        break;
                    case '5':
                        //hypoteneuse of trangle
                        break;
                    case '6':
                        //calculator
                        break;
                    case 'q': 
                        Console.WriteLine("\nGoodbye!");
                 
                        break;
                    default:
                        Console.WriteLine("\nInvalid entry\n");
                        break;
                }
                Console.WriteLine("hit a key");
                Console.ReadKey();
                Console.Clear();

            }
        }

        static string Menu()
        {
            //this displays a menu and returns the first charcater of the user choice
            Console.WriteLine("Enter Choice");
            Console.WriteLine("============");
            Console.WriteLine("1. Area of square");
            Console.WriteLine("2. Perimeter of square");
            Console.WriteLine("3. Area of Circle");
            Console.WriteLine("4. Hypoteneuse of triangle");
            Console.WriteLine("5. Calculator");
            Console.WriteLine("q. Quit");
            Console.Write("Choice>");
            string c =  Console.ReadLine();
            return c;
        }

        static double GetDoubleNumber(string prompt)
        {
            Boolean valid=false;
            double NumberIn=0;
            do
            {
                Console.Write(prompt);
                try
                {
                    NumberIn=double.Parse(Console.ReadLine());
                    valid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a valid number");
                    Console.ForegroundColor = ConsoleColor.White;
                    valid = false;
                }
            }
            while (!valid);
            return NumberIn;
        }

        static double RectangleArea(double w, double h)
        {
            return w*h;
        }
        static double SquarePerimeter(double SquareLength)
        {
            return SquareLength*4;
        }
    }
}

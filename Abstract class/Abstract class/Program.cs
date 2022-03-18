using System;
using Abstract_class.Models;

namespace Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Square Square = new Square(4);
            Rectangular Rectangular = new Rectangular(2, 3);
            int Key;
            do
            {
                Console.WriteLine($"Enter the option of your choice");
                Console.WriteLine($"1.Square area");
                Console.WriteLine($"2.Rectangular area");
                Console.WriteLine($"0.Quit");
                Console.WriteLine("********************************************");
                    
                Key = Convert.ToInt32(Console.ReadLine());

                switch (Key)
                {
                    case 1:

                        if (Square.side>0)
                        {
                            Console.WriteLine($"Square area={Square.CalcArea()}");
                            Console.WriteLine("********************************************");
                        }
                        else if (Square.side<=0)
                        {
                            Console.WriteLine("False information");
                            Console.WriteLine("********************************************");
                        }

                        break;

                    case 2:
                        if (Rectangular.width>0 & Rectangular.length >0)
                        {
                            Console.WriteLine($"Rectangular area={Rectangular.CalcArea()}");
                            Console.WriteLine("********************************************");
                        }
                        else if (Rectangular.width <= 0 || Rectangular.length <= 0)
                        {
                            Console.WriteLine("False information");
                            Console.WriteLine("********************************************");
                        }
                        break;

                    default: Console.WriteLine("Mode was entered incorrectly");
                        Console.WriteLine("********************************************");
                        break;
                    case 0:
                        Console.WriteLine("END");
                        Console.WriteLine("********************************************");
                        break;
                }
            } while (Key !=0);

           
        }
    }
}

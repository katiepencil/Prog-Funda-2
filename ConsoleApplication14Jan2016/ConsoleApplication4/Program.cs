using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'c' to calculate the first set of numbers, then hit 'enter'.");
            string goNoGo = Console.ReadLine();
            while (goNoGo == "c")          
            
                {
                int myResult = 0;
                Console.WriteLine("\r\nEnter a whole number, then press enter.");
                    string input = Console.ReadLine();
                    myResult = validateInput(input);

                Console.WriteLine("Please enter another whole number and press Enter");
                    input = Console.ReadLine();
                    myResult += validateInput(input);
                Console.WriteLine("Your result is " + myResult);
                
                Console.WriteLine("\r\n\r\nPress 'c' to calculate the next set of numbers, then press 'enter'. \r\nOr press 'x' to exit.");
                goNoGo = Console.ReadLine();
                }
            
            while (goNoGo != "x")
                {
                 Console.WriteLine("\r\n\r\nReally? Can't decide? Can't type? Please choose 'x' to exit, then press 'enter'.");
                    goNoGo = Console.ReadLine();
                }
            Console.WriteLine("\r\n\r\nGoodbye! Thank you for calculating with us!\r\nNOW you can hit any key to exit.");
            Console.ReadKey();
           }

                static private int validateInput(string input)
                {
                    int inputNum;
                    while (!int.TryParse(input, out inputNum))
                    {
                        Console.WriteLine("Invalid number, please enter another number!");
                        input = Console.ReadLine();
                    }
                    return inputNum;
                 }

     }           
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                bool run2 = true;
                while (run2)
                {
                    int userNum, newNum; // declaring my variables

                    Console.Write("Hello! Please enter your name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Hello, {0}, please enter a number between 1 and 100.", name);
                    userNum = int.Parse(Console.ReadLine());
                    newNum = userNum % 2; // function to make the number odd or even

                    while (userNum < 1 | userNum > 100)
                    {

                        Console.WriteLine("I'm sorry, you must enter a number between 1 and 100.");
                        run2 = true;
                        run = false;
                        userNum = int.Parse(Console.ReadLine());
                    }

                    if (newNum == 0) // if number entered is even, the block off code bellow will run
                    {


                        if (userNum <= 25 && userNum >= 2)
                        {
                            Console.WriteLine("{0}, your number is even and less than 25.", name);
                            run2 = false;
                            run = false;
                        }
                        else if (userNum > 26 && userNum < 60)
                        {
                            Console.WriteLine("{0}, your number is even.", name);
                            run2 = false;
                            run = false;
                        }
                        else if (userNum > 60 || userNum > 100)
                        {
                            Console.WriteLine("{0}, your number is even.", name);
                            run2 = false;
                            run = false;
                        }
                    }

                    else if (newNum == 1) // if number is odd, this block off code bellow will run

                    {
                        Console.WriteLine("{0}, your Number is {1} and odd.", name, userNum);
                        run2 = false;
                        run = false;
                    }


                }
            }
            bool response = true;
            while (response)
            {
                Console.WriteLine("Would like to continue, y/n?"); 
                string userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "y")
                {
                    response = false;
                    
                }
                else if (userAnswer == "n")
                {
                    Console.WriteLine("Goodbye!");
                    response = false;
                    run = false;
                }
                else
                {
                    Console.WriteLine("I'm sorry, please try again.");
                }
            }
        }
    }
}


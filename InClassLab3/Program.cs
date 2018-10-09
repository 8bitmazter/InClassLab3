using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont; //using bool for the application to repeat
            bool rename; //used for if they wish to rename theirself
            rename = true; //set for renaming
            while (rename)
            {
                Console.WriteLine("Hello, to begin this process may I please have your first name?");
                string uName = Console.ReadLine();
                cont = true; //making true so user could re-input data
                while (cont)
                {
                    Console.WriteLine("Hello {0} and thank you for intruducing yourself to me. To begin please enter a number between 1 and 100", uName);
                    int uNum = int.Parse(Console.ReadLine());

                    if (uNum > 100 || uNum < 0) //set for repeat process if over 100
                    {
                        Console.WriteLine("Please choose a number between 1 & 100. Try again");
                    }
                    else
                    {

                        if (uNum <= 25 && uNum % 2 == 1) //leave these above the even numbers or it will run on even since it's ahead
                        {
                            Console.WriteLine("{0}'s number is {1} and is a Odd Number", uName, uNum);
                        }
                        else if (uNum <= 25)
                        {
                            Console.WriteLine("{0}'s number is even and less than 25", uName);
                        }
                        else if (uNum >= 26 && uNum <= 60 && uNum % 2 > 0) //leave above the even
                        {
                            Console.WriteLine("{0}'s number is odd & is between 26 & 60", uName);
                        }
                        else if (uNum >= 26 && uNum <= 60)
                        {
                            Console.WriteLine("{0}'s number is even & is between 26 & 60", uName);
                        }
                        else if (uNum >= 60 && uNum % 2 == 1) //leave above the even
                        {
                            Console.WriteLine("{0}'s numer is odd and is greater than 60, for it's {1}", uName, uNum);
                        }
                        else if (uNum >= 60)
                        {
                            Console.WriteLine("{0}'s number is even and the number is greater than 60, for it's {1}", uName, uNum);
                        }

                    }
                    Console.WriteLine("Would you like to continue? Y/N?");
                    string answer = Console.ReadLine();
                    if (answer == "y" || answer == "Y") //repeat process
                    {
                        Console.WriteLine("Would you like to change your name? Y/N");
                        string answerName = Console.ReadLine();
                        if (answerName == "y" || answerName == "Y") //repeat without renaming process
                        {
                            cont = false;
                        }
                    }
                    else //Close out Program.
                    {
                        cont = false;
                        rename = false;
                    }
                }
            }
        }
    }
}

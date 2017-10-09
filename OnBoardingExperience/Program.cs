using System;

namespace OnBoardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            
            Console.WriteLine("Welcome to your Onboarding Experience!");
            

            user.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine("Hello " + user.FirstName);

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine("Welcome " + user.FirstName + " " + user.LastName);

            user.IsAccountOwner = AskBoolQuestion("Are you the account owner? ");
            Console.WriteLine("Great " + user.FirstName + " You're the account owner.");

            user.PinNumber = AskPinNumber("What would you like to set your 4 digit pin as? ", 4);
            Console.WriteLine("Thanks! Your pin has been set to: " + user.PinNumber);

            Console.WriteLine("Thank you for enjoying the Onboarding Experience and have a nice day!");
            Console.WriteLine("Data 'safely' stored on Equifax Server");


            Console.ReadLine();
        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();

        }

        static bool AskBoolQuestion(string question)
        {
            var IsAccountOwner = false;

            while (!IsAccountOwner)
            {
                var response = AskQuestion(question + "y or n");

                if (response == "y")
                {
                    IsAccountOwner = true;
                
                }
                else if (response == "n")
                {
                    Console.WriteLine("Invalid entry, please try again!");
                }
                else AskQuestion(question + " Type 'y' for 'yes' or 'n' for 'no'");
               
            }

            return IsAccountOwner;
        }

        static string AskPinNumber(string question, int length)
        {
            string numberString = null;

            while (numberString == null)
            {
                var response = AskQuestion(question);

                if (response.Length == length && Int32.TryParse(response, out int _))
                {
                    numberString = response;
                }
            }
            return numberString;
        }
    }

}

using System;


//Namespace
namespace numGuess
{
    //Main class
    class Program
    {
        //Entry Point Method; void, not returning anything; static, refers to function itself
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function to get info
            GreetUser(); //Ask for users name and greet
               
            while (true)
            {
                //Create a new Random object
                Random random = new Random();


                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 & 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        colorPrint(ConsoleColor.Red, "Enter an actual number, not a character|string");

                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {

                        colorPrint(ConsoleColor.Red, "Wrong number, please try again");


                    }
                }



                //Output success message

                colorPrint(ConsoleColor.Yellow, "Correct, you got it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }


        //Get and display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brian Tucker";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }
        
        //Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }


        //Print color message
        static void colorPrint(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}

namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
            var rng = new Random();
            int randomNumber = rng.Next(1, 30);

            Console.WriteLine("Howdy! Let's see if you can guess my favorite number...");
            Console.WriteLine();

            while (true)
            {


                string input = Console.ReadLine();
                int userInput = int.Parse(input);
                Console.WriteLine();

                if (userInput == randomNumber)
                {
                    Console.WriteLine($"You guessed it! Press enter to exit.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (userInput > randomNumber)
                {
                    Console.WriteLine($"Hey now! Too high, try again... :)");
                    Console.WriteLine();
                }
                else if (userInput < randomNumber)
                {
                    Console.WriteLine($"Oops! Too low, friend! Try again... :)");
                    Console.WriteLine();
                }
            }
        }

        //Ask the user for their favorite school subject. 
        //Store their answer in a variable
        //Pass the variable as the expression in a switch statement.
        //Create 5 different cases for different subjects. Each case will print the subject chosen and a custom message of your choosing.
        //Create a default case to handle any case not handled.


    }
}
        }
    }
}
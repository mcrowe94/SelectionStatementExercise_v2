namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Please choose between numbers 1 - 6 to view a school subject.");
            int userAnswer = int.Parse(Console.ReadLine());

            switch (userAnswer)
            {
                case 1:
                    Console.WriteLine("math - not my favorite, but props to you for being so good at it!");
                    break;
                case 2:
                    Console.WriteLine("science - I was always fasinated by science, it's a fun subject.");
                    break;
                case 3:
                    Console.WriteLine("language - I excelled in language!");
                    break;
                case 4:
                    Console.WriteLine("lunch - can't go wrong here!");
                    break;
                case 5:
                    Console.WriteLine("gym - I failed gym! Lol");
                    break;
                case 6:
                    Console.WriteLine("history - history is so important!");
                    break;
                default:
                    Console.WriteLine("Sorry, don't know that one!");
                    break;

            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");

            //Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
            var rng = new Random(); //this chooses a random number
            int randomNumber = rng.Next(1, 15); //I set the random number between these integers 

            Console.WriteLine("Howdy! Let's see if you can guess my favorite number...");
            Console.WriteLine();

            while (true)
            {


                string input = Console.ReadLine();
                int userInput = int.Parse(input);
                Console.WriteLine();

                if (userInput == randomNumber)
                {
                    Console.WriteLine($"You guessed it! Please press ENTER to quit application.");
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
    
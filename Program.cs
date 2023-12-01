// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace ControlStructure
{
    class program
    {
        public static void Main(string[] args)
        {
            string secretWord = "peace";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuuesses = false;
            string[] guesses = new string[guessLimit];



            //USING IF AND IFELSE LOOPS
            /*           {
                            if (guessCount < guessLimit)
                            {
                                Console.Write("Enter your guess: ");
                                guess = Console.ReadLine();
                                guessCount++;
                            }
                            else
                            {
                                outOfGUuesses = true;
                            }
                        }
                        if (outOfGUuesses)
                        {
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            Console.WriteLine("You win");
                        }

                    }*/
            //USING DO WHILE
            /*do
            {

                if (guessCount < guessLimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGUuesses = true;
                }
                if (guess != secretWord && !outOfGUuesses)
                {
                    continue;
                }
                if (outOfGUuesses)
                {
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("You win");
                }
            }
            while (guess != secretWord && !outOfGUuesses);
        }*/


            // Switch Statement
            static string GetDay(int daynum)
            {
                string dayname;
                switch (daynum)
                {
                    case 0:
                        dayname = "Sunday";
                        break;
                    case 1:
                        dayname = "Monday";
                        break;
                    case 2:
                        dayname = "Tuesday";
                        break;
                    case 3:
                        dayname = "Wednesday";
                        break;
                    case 4:
                        dayname = "Thursday";
                        break;
                    case 5:
                        dayname = "Friday";
                        break;
                    case 6:
                        dayname = "Saturday";
                        break;
                    default:
                        dayname = "Invalid number";
                        break;
                }
                return dayname;
            }

                    //WHILE LOOP
                Dictionary<string, int> personAges = new Dictionary<string, int>()
                {
                    { "TIMMY", 25 },
                    { "JIDE", 30 },
                    { "Chibuzor", 22 },
                    { "Tolu", 28 },
                    { "Seyi", 35 }
                };

                var enumerator = personAges.GetEnumerator();

                // While loop to iterate through the dictionary
                while (enumerator.MoveNext())
                {
                    KeyValuePair<string, int> currentPair = enumerator.Current;

               
                Console.WriteLine($"Name: {currentPair.Key}, Age: {currentPair.Value}");
                }
            enumerator.Dispose();
    }
    }
}



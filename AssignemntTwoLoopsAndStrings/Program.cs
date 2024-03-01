
namespace AssignemntTwoLoopsAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set to false to exit program.
            bool exit = true;
            while (exit) 
            {
                Console.WriteLine("\n------------------");
                Console.WriteLine("Welcome to the main menu!");
                Console.WriteLine("You navigate me via key the presses shown below.");
                Console.WriteLine("1 - Individuals");
                Console.WriteLine("2 - Groups");
                Console.WriteLine("3 - Repeat 10 Times");
                Console.WriteLine("4 - The 3rd Word");
                Console.WriteLine("0 - Exit Program");
                Console.WriteLine("------------------\n");
                // Read KeypPress
                ConsoleKeyInfo input;
                input = Console.ReadKey();

                if (input.Modifiers.HasFlag(ConsoleModifiers.Shift))
                {
                    switch (input.Key)
                    {
                        // EasterEgg! if you hold "Shift" and press "1"
                        case ConsoleKey.D1:
                            Console.WriteLine("     IT'S THE ROFLCOPTER!!!     ");
                            Console.WriteLine("");
                            Console.WriteLine("                 -----------!-----------");
                            Console.WriteLine("-----------!-----------  /=====\\");
                            Console.WriteLine("          |===\\_________/_  o  |");
                            Console.WriteLine("         /_]    o o  o o____   /");
                            Console.WriteLine("        <_]___[]_______<____>/");
                            Console.WriteLine("            o              o");
                            break;
                    }
                }
                switch (input.Key)
                {
                    case ConsoleKey.D1: menuChoiceOne(); break;
                    case ConsoleKey.D2: menuChoiceTwo(); break;
                    case ConsoleKey.D3: menuChoiceThree(); break;
                    case ConsoleKey.D4: menuChoiceFour(); break;
                    case ConsoleKey.D0: exit = false; break;
                    default: Console.WriteLine("Please enter a valid input: 1, 2, 3, 4 or 0."); break;
                }
            }
            void menuChoiceOne()
            {
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();
                int age;

                // Try to convert string input to int age
                if (int.TryParse(input, out age))
                {
                    // We successfully parsed use input. 
                    // if you enter < 0 you get in free I guess!.
                    if (age < 0)
                    {
                        Console.WriteLine("Invalid Age.");
                    }
                    else if (age < 5) {
                        Console.WriteLine("Gratis!");
                    }
                    else if (age < 20)
                    {
                        Console.WriteLine("Ungdomspris: 80kr");
                    }
                    else if (age > 100)
                    {
                        Console.WriteLine("Gratis!");
                    }
                    else if (age > 64)
                    {
                        Console.WriteLine("Pensionärspris: 90kr");
                    }
                    else
                    {
                        Console.WriteLine("Standardpris: 120k");
                    }
                }

                else
                {
                    Console.WriteLine("Couldn't convert input to Integer.");
                }
                return;
            }
            void menuChoiceTwo()
            {
                Console.Write("\nPlease enter how big the group is: ");
                string input = Console.ReadLine();
                int groupSize;
                int sumPrice = 0;
                // TryParse returns True and sets groupSize to input nr OR
                // returns False and doesn't run any code in the {if it can not set input value to a integer.}
                if (int.TryParse(input, out groupSize) && groupSize > 0)
                {
                    // start at 1 and increase groupSize by 1 to be less confusing for end-user.
                    for (int i = 1; i < groupSize+1; i++)
                    {
                        Console.Write($"Please enter the age of person {i} : ");
                        input = Console.ReadLine();
                        int age;
                        if (int.TryParse(input, out age)){
                            PriceNote(age);
                            // This handles the total cost for the group by just inputting each persons age.
                            sumPrice += PriceAdder(age);
                        } else
                        {
                            Console.WriteLine("Couldn't convert input to Integer. Please start over.");
                            return; // return breaks out of this function and back to the main menu.
                        }
                    }
                } 
                else 
                { 
                    Console.WriteLine("No negative or decimal numbers and no letters."); 
                }
                Console.WriteLine($"Total cost for the group of {groupSize} is: {sumPrice}");
            }
            void menuChoiceThree()
            {
                Console.WriteLine("\nThis function repeats what you write 10 times");
                Console.Write("Type something!: ");
                string input = Console.ReadLine();
                string output = "";
                //List<String> repeatedInput = new List<String>();
                for (int i = 0; i < 10; i++)
                {   
                    output += input;
                    //repeatedInput.Add(input);
                    //Console.Line(input);
                }
                /*
                foreach(string word in repeatedInput)
                {
                    Console.Write(word + ", ");
                }
                */
                Console.WriteLine(output);
                Console.WriteLine();
                return;
            }
            void menuChoiceFour()
            {
                Console.WriteLine();
                Console.WriteLine("""This function prints out every 3rd word in a sentence split by whitespaces " " """);
                Console.Write("Minimum 3 white spaces:");
                string input = Console.ReadLine();
                string[] splitInput = input.Split(" ");
                Console.WriteLine();
                if (splitInput.Length < 2) 
                {
                    Console.WriteLine("Input needs to be at least 3 words separated by a space.");
                    return;
                } 
                else
                {
                    // start at 3rd word in array and increment i by 3 to get every following 3d word.
                    // as long as i is less than splitInput.Length
                    for(int i = 2;i < splitInput.Length; i += 3)
                    {
                        string pickOutWord = splitInput[i];
                        Console.Write(pickOutWord + " ");
                        
                    }
                }
            }
            // I SHOULD use this in menuChoiceOne but that's not what the assignment says to do.
            void PriceNote(int age)
            {
                if (age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensionärspris: 90kr");
                }
                else
                {
                    Console.WriteLine("Standardpris: 120k");
                }
            }
            // I SHOULD use this in menuChoiceOne but that's not what the assignment says to do.
            int PriceAdder(int age)
            {
                if (age < 20)
                {
                    return 80;
                }
                else if (age > 64)
                {
                    return 90;
                }
                else
                {
                    return 120;
                }
            }
        }


    }
}

using System;

public class TestScore
{
    public static void Main()
    {
        //variables
        string name;
        double score;

        Console.WriteLine("Welcome to the Acme Student Test Score commentator");
        //if exit is typed program closes if not it carries on
        while (true)
        {
            Console.WriteLine("Enter your name (or 'exit' to quit): ");
            name = Console.ReadLine();

            if (name.ToLower() == "exit")
                break;
            //the statements that allow the code to work as intended
            Console.WriteLine("Enter the test score: ");
            if (double.TryParse(Console.ReadLine(), out score))
            {
                if (score >= 0 && score <= 100)
                {
                    Console.WriteLine("Hello {0}", name);
                    Console.WriteLine("You scored {0}", score);

                    if (score < 40)
                    {
                        Console.WriteLine("This is a FAIL score");
                    }
                    else
                    {
                        Console.WriteLine("This is a PASS score");
                        if (score >= 75)
                        {
                            Console.WriteLine("You did very well!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Oh dear - you have entered an invalid test score");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric test score.");
            }
        }
    }
}

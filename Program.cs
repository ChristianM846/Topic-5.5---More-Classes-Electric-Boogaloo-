namespace Topic_5._5___More_Classes__Electric_Boogaloo_
{
    //Christian Moyes
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string doneChoice;

            Die die1 = new Die();
            Die die2 = new Die();

            while (!done)
            {
                Console.Clear();
                Console.WriteLine("Let's roll some dice!");
                Console.WriteLine("Press ENTER to roll 2 dice:");
                Console.ReadLine();
                die1.RollDie();
                Console.WriteLine($"Die 1 = {die1}");
                die1.DrawRoll();
                Thread.Sleep(800);
                die2.RollDie();
                Console.WriteLine($"Die 2 = {die2}");
                die2.DrawRoll();
                Console.WriteLine();
                Thread.Sleep(500);

                if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine("The rolls are doubles.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The rolls are not doubles.");
                    Console.WriteLine();
                }

                Thread.Sleep(500);

                if (die1.Roll + die2.Roll == 7)
                {
                    Console.WriteLine("The sum of the rolls equals 7.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The sum of the rolls does not equal seven.");
                    Console.WriteLine();
                }

                Thread.Sleep(500);

                if (die1.Roll == 1 && die2.Roll == 1)
                {
                    Console.WriteLine("Snake eyes! Both rolls are ones.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Not snake eyes. At least one of the rolls is not one.");
                    Console.WriteLine();
                }

                Thread.Sleep(500);

                if (die1.Roll + die2.Roll == 2 || die1.Roll + die2.Roll == 4 || die1.Roll + die2.Roll == 6 || die1.Roll + die2.Roll == 8 || die1.Roll + die2.Roll == 10 || die1.Roll + die2.Roll == 12)
                {
                    Console.WriteLine("The sum of the rolls is even.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The sum of the rolls is odd.");
                    Console.WriteLine();
                }

                Thread.Sleep(500);

                if (die1.Roll + 1 == die2.Roll || die1.Roll - 1 == die2.Roll)
                {
                    Console.WriteLine("The rolls are in sequence.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The rolls are not in sequence.");
                    Console.WriteLine();
                }

                Thread.Sleep(500);

                if (die1.Roll > die2.Roll)
                {
                    Console.WriteLine($"Die 1's roll of {die1} is greater than die 2's roll of {die2}");
                }
                else if (die1.Roll < die2.Roll)
                {
                    Console.WriteLine($"Die 2's roll of {die2} is greater than die 1's roll of {die1}");
                }
                else
                {
                    Console.WriteLine("The rolls are equal, and thus neither is larger than the other.");
                }

                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("Would you like to run the program again? (y/n)");

                doneChoice = Console.ReadLine().Trim().ToLower();

                while (doneChoice != "y" && doneChoice != "n")
                {
                    Console.WriteLine("That is not a valid input, please try again. (y/n)");
                    doneChoice = Console.ReadLine().Trim().ToLower();
                }

                if (doneChoice == "n")
                {
                    Console.WriteLine("Okay, goobye.");
                    done = true;
                }

            }
            


        }
    }
}

namespace OOP_FINALS_ANGELES
{
    internal class Sapukan
    {
        private static Random _random = new Random();
        public static void Jombagan()
        {
            while (true)
            {
                int buhaykakampi = _random.Next(50, 151);
                int kapangyarihan = _random.Next(25, 51);
                int buhaykalaban = _random.Next(50, 151);
                int kapangyarihan1 = _random.Next(25, 51);

                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Welcome to my trap {Program.Player}, how is it? Is it up to your liking");
                Console.WriteLine(); Thread.Sleep(2000);
                Console.WriteLine("YOU WILL NEED TO DEFEAT ME FIRST BEFORE YOU CAN LEAVE!");
                Console.WriteLine(); Thread.Sleep(2000);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER TO PROCEED");
                Console.WriteLine(); Console.ReadKey();
                Console.ResetColor();
                Console.Clear();

                while (buhaykakampi > 0 && buhaykalaban > 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("DO YOU WANT TO ATTACK OR RUN");
                    Console.ResetColor();
                    string input = Console.ReadLine();

                    if (input.Equals("attack", StringComparison.CurrentCultureIgnoreCase))
                    {
                        int harm = _random.Next(1, kapangyarihan + 1);
                        buhaykalaban -= harm;
                        Console.WriteLine($"You attack the enemy for {harm} damage. Enemy health: {buhaykalaban}");
                    }
                    else if (input.Equals("run", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("You run away!");
                        Console.WriteLine("You were caught and is now dead.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        continue;
                    }

                    if (buhaykalaban > 0)
                    {
                        int harmer = _random.Next(1, kapangyarihan1 + 1); // Randomly generate enemy damage
                        buhaykakampi -= harmer;
                        Console.WriteLine($"The enemy attacks you for {harmer} damage. Your health: {buhaykakampi}");
                    }
                }

                if (buhaykakampi <= 0)
                {
                    Console.WriteLine("You died! Game over.");
                }
                else
                {
                    Console.WriteLine("You won! Congratulations!");
                }

                Console.WriteLine("Do you want to play again? (yes/no)");
                string retryInput = Console.ReadLine();

                if (retryInput.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                }
                else if (retryInput.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
            }
        }
    }
}


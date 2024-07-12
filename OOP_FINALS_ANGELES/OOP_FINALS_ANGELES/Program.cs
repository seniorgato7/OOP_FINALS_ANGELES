namespace OOP_FINALS_ANGELES
{
    internal class Program
    {
        public static string Player = "";
        public static void Main(string[] args)
        {
            Player = Name();
            Console.ResetColor();
            Console.WriteLine($"\nWell {Player}, how nice it is to meet you!"); Thread.Sleep(2000); Console.WriteLine();
            Console.WriteLine($"Are you here with someone, {Player}?"); Thread.Sleep(2000);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 = ANSWER TRUTHFULLY \n2 = ANSWER UNTRUTHFULLY"); Thread.Sleep(1500); Console.WriteLine();
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine($"Hold that thought. {Player} can you help me with something?"); Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("TYPE 'yes' OR 'no' TO ANSWER\n");
            Console.ResetColor();
            string ans = Console.ReadLine();
            FirstChoice(ans);
        }
        public static string Name()
        {
            Console.WriteLine("Hello, you look new here. Whats your name?\n");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("TYPE YOUR NAME BELOW");
            Console.WriteLine();
            Console.ResetColor();
            return Console.ReadLine();
        }
        static string FirstChoice(string ans)
        {
            if (ans.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Proceed.Story1();
            }
            else if (ans.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Console.WriteLine("Okay nevermind then.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("lmao");
            }
            return ans;
        }
    }
}

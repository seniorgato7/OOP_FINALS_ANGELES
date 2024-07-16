namespace OOP_FINALS_ANGELES
{
    internal class Proceed
    {
        public static void Story1()
        {
                List<string> list1 = new List<string>
            {
                "Great! We need to go down the warehouse just to get some stuff in the warehouse since Daisy has been asking me to get them ever since the world began."
            };
                foreach (string nene in list1)
            {        
                Console.WriteLine(nene);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER");
                Console.WriteLine();
                Console.ReadKey();
            }

                List<string> list2 = new List<string>
            {
                "He then lets out this obnoxious laugh and you're still just standing there waiting to ask his name and ask just who he is"
            };
                foreach (string nene in list2)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(nene);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER");
                Console.ResetColor();
                Console.WriteLine(); Console.ReadKey();
            }

                List<string> list3 = new List<string>
            {
                "Oh I am one hundred percent sure you've heard of her and how she's such a little-"
            };
                foreach (string nene in list3)
            {
                Console.WriteLine(nene);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER");
                Console.ResetColor();
                Console.WriteLine(); Console.ReadKey();
            };

                List<string> list4 = new List<string>
            {
                "He then just started walking while talking as if he expects you to just follow where he's going."
            };
                foreach (string nene in list4)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(nene);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER");
                Console.ResetColor();
                Console.WriteLine(); Console.ReadKey();
            }
    
                List<string> list5 = new List<string>
            {
                "Yeah and so she's been egging me on and on about this thing. She doesn't even do that much and tho yes she's my boss and I assume she's your boss too and I just-"
            };
                foreach (string nene in list5)
            {
                Console.WriteLine(nene);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER");
                Console.ResetColor();
                Console.WriteLine(); Console.ReadKey();
            }
    
                List<string> list6 = new List<string>
            {
                "As you're walking by you then overhear this group of people talking about something"
            };
                foreach (string nene in list6)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(nene);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER");
                Console.ResetColor();
                Console.WriteLine(); Console.ReadKey();
            }

            Console.Clear();

                List<string> list7 = new List<string>
            {
                "Have you heard what happened to Kenny? It was tragic.",
                "Yeah I don't even believe it",
                "Thats three now this month.",
                "Thats kind of alarming now dont you think?"
            };
                foreach (string nene in list7)
            {
                Console.WriteLine(nene);
                Thread.Sleep(2000);
            }
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER");
                Console.ResetColor();
                Console.WriteLine(); Console.ReadKey();

                List<string> list8 = new List<string>
            { 
                "Alarming? Tragic? Three this month? What was that about? You thought to yourself."
            };
                foreach (string nene in list8)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(nene);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PRESS ENTER");
                Console.ResetColor();
                Console.WriteLine(); Console.ReadKey();
            }
            
                List<string> list9 = new List<string>
            {
                "After a long walking while talking and also while trying to keep up with this stranger whom you havent even asked for his name. You finally reach the warehouse",
                "As you enter the warehouse you are greeted by this stagnant air which smells like an old cabinet.",
                "You then see a group of people just staring at you while you are walking in",
                "and the stranger is still walking and talking at the same time.",
                "Lots of murmuring in this place huh.' You thought to yourself."
            };
                foreach (string nene in list9)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(nene); Thread.Sleep(4000);
                Console.ResetColor();
            }
            
            Console.Clear();

                List<string> list10 = new List<string>
            {
                $"Gosh! Darn it! {Program.Player} I forgot the keys. Can you get it for me? Please? Its just in that door right next to the exit. Thank you {Program.Player}!"
            };
            foreach (string nene in list10)
            {
                Console.WriteLine(nene);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("GET KEYS?");
                Console.WriteLine();
            }
                Console.WriteLine("TYPE 'yes' OR 'no'");
                Console.ResetColor();
                string inevitable = Console.ReadLine();

            Combatan_Intro();
}
    public static void Combatan_Intro()
{
    Console.Clear();

    List<string> list11 = new List<string>
    {
        "You went in to get the keys and you find yourself in a room full of lockers.",
        "Why is there so much locker in here? How will I find those keys in here?",
        "The stranger then appears behind you asking whats wrong.",
        "Why are the lights turned off? He says",
        "He then comes in and flicks the switch",
        "You then just stroll casually inside the locker filled room and you notice this one particular locker.",
        "You tried opening it but as you were opening its door you noticed your field of vision going darker.",
    };
    foreach (string nene in list11)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(nene);Thread.Sleep(2500);
    }

    List<string> list12 = new List<string>
    {
        "No lights huh. Let me get my flashlight in my locker. I'll be right back."
    };

    foreach (string nene in list12)
    {
        Console.WriteLine(nene); Thread.Sleep(2000);
    }

    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("You then hear a door close."); Thread.Sleep(2000);
    Console.ResetColor();

    List<string> list13 = new List<string>
    {
        "You then hear muffled sounds everywhere.",
        "You realized there were bodies inside and- ",
        "The locker you opened in front of you had someone in it and it pulled you telling you to"

    };
    foreach (string nene in list12)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(nene); Thread.Sleep(2000);
    }

    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("RUN");Thread.Sleep(2000);
    Console.ResetColor();
    Console.Clear();

    Sapukan.Jombagan();
        
    }
}

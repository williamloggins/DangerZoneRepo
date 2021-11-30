using System;

namespace TextAdventure
{
    class Program
    {
        public static Player currentPlayer = new Player();

        static void Main(string[] args)
        {
            IntroScene();
            SwordScene();
            SwordSceneLoop();
            FirstLoop();
            DoorIntro();
            DoorChoosing();

            Console.ReadKey();
            EndApplication();
        }

        //static int Health(int)
        //{
        //    int _healthPoints = 100;

        //    if (Console.ReadLine().ToUpper() == "HEALTH")
        //    {
        //        Console.WriteLine("Health is currently {0}", _healthPoints);
        //    }

        //}


        static void IntroScene()
        {
            Console.WriteLine("Throughout this game, you will press Enter to continue.\n");
            Console.WriteLine("\nGo ahead and try that now.");
            Console.ReadLine();
            Console.WriteLine("Nice job. You will keep pressing Enter until the game is over and quits.");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Now, be creative, and enter your name: ");
            currentPlayer.name = Console.ReadLine();
            if (currentPlayer.name == "")
            {
                Console.WriteLine("Don't remember your own name? Alright.. we will just go with idiot then.");
                currentPlayer.name = "idiot";
                Console.ReadLine();
            }
            Console.WriteLine("Cool name, {0}. Ready?", currentPlayer.name);
            Console.ReadLine();
            Console.Clear();
        }

        static void SwordScene()
        {
            Console.WriteLine("Press enter 5 times FAST to start {0}!", currentPlayer.name);
            Console.ReadKey();


            Console.WriteLine($"         /\\         ");
            Console.WriteLine($"        /  \\              ");
            Console.WriteLine($"       |----|    ");
            Console.WriteLine($"       |----|       ");
            Console.WriteLine($"  /|___|----|____|\\    ");
            Console.ReadKey();
            Console.WriteLine($"  \\|____    _____|/     ");
            Console.WriteLine($"        | | |                        ");
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.ReadKey();
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.ReadKey();
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | |                                   ");
            Console.ReadKey();
            Console.WriteLine($"        | | |                                   ");
            Console.WriteLine($"        | | /                                  ");
            Console.WriteLine($"        |  /                                   ");
            Console.WriteLine($"        | /                                   ");
            Console.WriteLine($"        |/                                    ");
            Console.ReadKey();

            Console.WriteLine("\nBAM");
            Console.ReadLine();
            Console.Clear();


        }

        static void SwordSceneLoop()
        {
            Console.WriteLine("\nYou just got a shiny sword!");
            Console.ReadLine();
            Console.WriteLine("\nIt's very dull though.");
            Console.ReadLine();
            Console.WriteLine("\nThe tip is pretty pointy!");
            Console.ReadLine();
            Console.WriteLine("\nBut you'd have to push really hard.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-------------That was pretty cool right? Want to do it again?--------------\n \nType either option and press enter:\nYeah!\nNo");
            Console.ReadLine();
        }

        static void FirstLoop()
        {
            string userValue = Console.ReadLine().ToUpper();

            switch (userValue)

            {
                case "YEAH!":
                    SwordScene();
                    break;

                case "YEAH":
                    SwordScene();
                    break;

                case "YES":
                    SwordScene();
                    break;

                case "YES!":
                    SwordScene();
                    break;

                case "NO":
                    DoorIntro();
                    break;

                case "NO!":
                    DoorIntro();
                    break;

                default:
                    Console.WriteLine("No really, choose one");
                    FirstLoop();
                    break;
            }
        }

        //DOOR CHOOSING BIT----------------------------------------------
        //---------------------------------
        //---------------

        static void DoorIntro()
        {
            Console.WriteLine("Okay, now you're armed. Press Enter.\n");
            Console.ReadLine();
            Console.WriteLine("By the way, you're going to press Enter a lot, alright {0}? Just accept it.\n", currentPlayer.name);
            Console.ReadLine();
            Console.WriteLine("Just the way it is.\n");
            Console.ReadLine();
            Console.WriteLine("The way the cookie....crumbles\n");
            Console.ReadLine();
            Console.WriteLine("Anyways, whattya know! There are some doors to choose from.\n");
            Console.ReadLine();
            Console.WriteLine("---------Don't forget, {0}! Type the answer and press ENTER.---------", currentPlayer.name);
            Console.ReadLine();
            Console.Clear();
            DoorChoosing();
        }

        static void DoorChoosing()
        {
            Console.WriteLine("\nChoose a door:\n1)\n3)");

            string userValue = Console.ReadLine().ToUpper();

            switch (userValue)

            {
                case "1":
                    DoorOne();
                    break;

                case "2":
                    DoorTwo();
                    break;

                case "3":
                    DoorThree();
                    break;

                default:
                    Console.WriteLine("Come on {0}, seriously pick one.", currentPlayer.name);
                    DoorChoosing();
                    break;
            }
        }

        static void DoorOne()
        {
            Console.WriteLine("Thanks.");
            Console.ReadLine();
            Console.WriteLine("A valid choice, great job.");
            Console.ReadLine();
            Console.WriteLine("WAIT WHAT");
            Console.ReadLine();
            Console.WriteLine("BOB ROSS IS IN HERE?!?!");
            Console.ReadLine();
            Console.Clear();
            BigQuestion:
            Console.WriteLine("....do you wanna slash him?");

            string userValue = Console.ReadLine().ToUpper();

            ////this needs to be separated i think?

            switch (userValue)
            {
                case "YES":
                    BobRossYes();
                    break;

                case "YEAH":
                    BobRossYes();
                    break;

                case "YES!":
                    BobRossYes();
                    break;

                case "YEAH!":
                    BobRossYes();
                    break;

                case "NO":
                    BobRossNo();
                    break;

                case "NO!":
                    BobRossNo();
                    break;

                default:
                    Console.WriteLine("It's a simple yes or no question, buddy");
                    goto BigQuestion;
            }

        }

        static void DoorTwo()
            {
                Console.WriteLine("Door two wasn't an option.");
                Console.ReadLine();
                Console.WriteLine("Think I'm coding three whole options purely for your entertainment?");
                Console.ReadLine();
                Console.WriteLine("Ain't nobody got time for that. Pick one or three.");
                Console.ReadLine();
                Console.Clear();
                DoorChoosing();
            }

        static void DoorThree()
            {
                int _healthPoints = 100;//implement health here?
                Console.WriteLine("door three option");
            }

        static void BobRossYes()
            {
                Console.WriteLine("{0} seriously?!? YOU ARE A MONSTER!!!", currentPlayer.name);
                Console.ReadLine();
                Console.WriteLine("BOB ROSS IS A SAINT AND HERO TO THIS COUNTRY");
                Console.ReadLine();
                Console.WriteLine("Really though... bro why?");
                Console.ReadLine();
                Console.WriteLine("You know what? You lose.");
                Console.Clear();
                EndApplication();
            }

        static void BobRossNo()
        {
            Console.WriteLine("Thank goodness you're not a monster.");
            Console.ReadLine();
            Console.WriteLine("Robert Norman Ross was an American painter, art instructor and television host.");
            Console.WriteLine("He was the creator and host of The Joy of Painting, an instructional television program that aired");
            Console.WriteLine("from 1983 to 1994 on PBS in the United States, Canada, Latin America, and Europe.");
            Console.ReadLine();
            Console.WriteLine("....welp okay, on to door 3 then");
            Console.Clear();
            DoorThree();
        }

        //DOOR CHOOSING BIT-------
        //-------------------------------------
        //----------------------------------------------------------








        //guitar art and end application

        static void GuitarShotgun()
        {
            Console.WriteLine("                                            ");
            Console.WriteLine("                           _____                       ");
            Console.WriteLine("                          /   ,'                      ");
            Console.WriteLine("                         /   ,                                  ");
            Console.WriteLine("                        /   ,                ");
            Console.WriteLine("                       /   '                       ");
            Console.WriteLine("                      /   ,'                    ");
            Console.WriteLine("                      '.__|                      ");
            Console.WriteLine("                       |  |                         ");
            Console.WriteLine("                       |__|                          ");
            Console.WriteLine("                       |  |                    ");
            Console.WriteLine("                       |__|                          ");
            Console.WriteLine("                       |  |                      ");
            Console.WriteLine("                       |__|                     ");
            Console.WriteLine("                       |  |                       ");
            Console.WriteLine("                       |__|                   ");
            Console.WriteLine("                       |, |                                   ");
            Console.WriteLine("                       |--|                ");
            Console.WriteLine("                       |__|                                ");
            Console.WriteLine("                       |--|                     ");
            Console.WriteLine("                       |__|                     ");
            Console.WriteLine("                       |__|                      ");
            Console.WriteLine("                       |__|'     ____                  ");
            Console.WriteLine("                  _,.-'     ',_,' o /                    ");
            Console.WriteLine("                 /     8888        /             ");
            Console.WriteLine("                 |                /               ");
            Console.WriteLine("                  1              /               ");
            Console.WriteLine("                  `L   8888     /               ");
            Console.WriteLine("                   |           /                ");
            Console.WriteLine("                  /    ====    \\                ");
            Console.WriteLine("                 /     ____     \\                 ");
            Console.WriteLine("                /     (____)  o  \\                  ");
            Console.WriteLine("               /             o    \\                   ");
            Console.WriteLine("              /             o     ,'                    ");
            Console.WriteLine("             /               _,.'^                    ");
            Console.WriteLine("           ',,..--~~^-------'                                  ");






            Console.WriteLine(@"           ,________________________________                             ");
            Console.WriteLine(@"          | __________,----------._[____]  "" -,__ __...-----===        ");
            Console.WriteLine(@"                   (_(||||||||||||)___________ / ""              |       ");
            Console.WriteLine(@"                      `----------'        [ ))""                 |           ");
            Console.WriteLine(@"                                            ""    `, _, --...___ |       ");
            Console.WriteLine(@"                                                                ""       ");


            Console.ReadLine();

        }

        static void EndApplication()
        {
            Console.WriteLine("Loser.");
            Console.ReadLine();
        }
    }

}
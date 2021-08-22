using System;

namespace TextBasedRpg
{
    class Program
    {
        static void Main()
        {

            //Vars//
            int money;
            string Prof;
            int huntChance;
            int huntxp = 0;
            int days = 1;
            int LbsOfFood = 50;
            Random rnd = new Random();
            bool hasGun = false;
            bool hasGun2 = true;
            int diff = 15;
            int diff2 = 4;


            Console.WriteLine("Hello Welcome To The Wild West");
            Console.Write("Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("What Difficulty?");
            Console.WriteLine("1 - Easy - 10 lbs/day");
            Console.WriteLine("2 - Normal - 15 lbs/day");
            Console.WriteLine("3 - Hard - 20 lbs/day");
            Console.WriteLine("4 - Even Chuck Norris Fears Me - 25 lbs/day");
            string difficulty = Console.ReadLine();
            if (difficulty == "1")
            {
                diff = 10;
                diff2 = ((99 * 56)* 99);
            }
            if (difficulty == "2")
            {
                diff = 15;
            }
            if (difficulty == "3")
            {
                diff = 20;
                diff2 = 3;
            }
            if (difficulty == "4")
            {
                diff = 25;
                diff2 = 3;
            }
            Console.WriteLine("What Profession Are You?");
            Console.WriteLine("");
            Console.WriteLine("1 - Farmer $500  Enhanced Hunting Experience");
            Console.WriteLine("2 - Lawyer $1000 Moderate Hunting Experience");
            Console.WriteLine("3 - Banker $3000 Lacking  Hunting Experience");
            string strProf = Console.ReadLine();

            if (strProf == "1")
            {
                Prof = "Farmer";
                money = 500;
                huntChance = 4;
                Console.WriteLine("You Have, $" + money + ", And Your Profession Is " + Prof);
                Console.WriteLine("Time To Start Your Journey, " + Name);
                StartOfGame();
            }
            if (strProf == "2")
            {
                Prof = "Lawyer";
                money = 1000;
                huntChance = 3;
                Console.WriteLine("You Have, $" + money + ", And Your Profession Is " + Prof);
                Console.WriteLine("Time To Start Your Journey, " + Name);
                StartOfGame();
            }
            if (strProf == "3")
            {
                Prof = "Banker";
                money = 3000;
                huntChance = 2;
                Console.WriteLine("You Have, $" + money + ", And Your Profession Is " + Prof);
                Console.WriteLine("Time To Start Your Journey, " + Name);
                StartOfGame();
            }
            if (strProf == "Hacker")
            {
                Prof = "Hacker";
                money = 6969;
                LbsOfFood = 6969;
                huntChance = 6;
                hasGun = true;
                Console.WriteLine("You Have, $" + money + ", And Your Profession Is " + Prof);
                Console.WriteLine("Time To Start Your Journey, " + Name);
                StartOfGame();
            }

            void StartOfGame()
            {
                Console.WriteLine("Day:" + days);
                Console.WriteLine("What Would You Like To Do?");
                Console.WriteLine("");
                Console.WriteLine("1 - Hunt");
                Console.WriteLine("2 - Look For Town W/ Shop");
                Console.WriteLine("3 - Explore");
                string Answer1 = Console.ReadLine();
                if (Answer1 == "Hacker")
                {
                    money = money + 6969;
                    LbsOfFood = LbsOfFood + 6969;
                }
                if (Answer1 == "3")
                {
                    explore();
                }
                if (Answer1 == "1")
                {
                    if (Prof == "Farmer")
                    {
                        int hunt = rnd.Next(1, 5);
                        if (hunt < huntChance)
                        {
                            Console.WriteLine("You Have Got A Buffalo, + 20lbs of Food");
                            LbsOfFood = LbsOfFood + 20;
                            huntxp = huntxp + 1;
                            Console.WriteLine("Your Hunting Experience is, " + huntxp);
                            if (huntxp == 5)
                            {
                                Console.WriteLine("You Just Leveled Up Your Hunting Level");
                                huntxp = 0;
                                huntChance = huntChance + 1;
                            }
                            restart();
                        }
                        else
                        {
                            Console.WriteLine("You Failed To Catch Anything");
                            restart();
                        }
                    }
                    if (Prof == "Lawyer")
                    {
                        int hunt = rnd.Next(1, 5);
                        if (hunt < huntChance)
                        {
                            Console.WriteLine("You Have Got A Buffalo, + 20lbs of Food");
                            LbsOfFood = LbsOfFood + 20;
                            huntxp = huntxp + 1;
                            Console.WriteLine("Your Hunting Experience is, " + huntxp);
                            if (huntxp == 10)
                            {
                                Console.WriteLine("You Just Leveled Up Your Hunting Level");
                                huntxp = 0;
                                huntChance = huntChance + 1;
                            }
                            restart();
                        }
                        else
                        {
                            Console.WriteLine("You Failed To Catch Anything");
                            restart();
                        }
                    }
                    if (Prof == "Banker")
                    {
                        int hunt = rnd.Next(1, 5);
                        if (hunt < huntChance)
                        {
                            Console.WriteLine("You Have Got A Buffalo, + 20lbs of Food");
                            LbsOfFood = LbsOfFood + 20;
                            huntxp = huntxp + 1;
                            Console.WriteLine("Your Hunting Experience is, " + huntxp);
                            if (huntxp == 10)
                            {
                                Console.WriteLine("You Just Leveled Up Your Hunting Level");
                                huntxp = 0;
                                huntChance = huntChance + 1;
                            }
                            restart();
                        }
                        else
                        {
                            Console.WriteLine("You Failed To Catch Anything");
                            restart();
                        }
                    }
                    if (Prof == "Hacker")
                    {
                        Console.WriteLine("You Have Got A Buffalo, + 2̷̣̳̈́0̵͕̜̾͑0̵̼͝lbs of Food");
                        LbsOfFood = LbsOfFood + 200;
                        huntxp = huntxp + 200;
                        Console.WriteLine("Your Hunting Experience is, " + huntxp);
                        if (huntxp == 10)
                        {
                            Console.WriteLine("You Just Leveled Up Your Hunting Level");
                            huntxp = 0;
                            huntChance = huntChance + 1;
                        }
                        restart();
                    }
                }

                if (Answer1 == "2")
                {
                    int shop = rnd.Next(1, 2);
                    if (shop == 1)
                    {
                        int rob = rnd.Next(1, diff2);
                        if (rob == 1)
                        {
                            Console.WriteLine("Put Your Darn Hands Up!");
                            Console.WriteLine("???");
                            Console.WriteLine("A grown Man with a gun says he is gunna shoot ya. do you wanna pull out a gun? Y/N");
                            string gun1 = Console.ReadLine();
                            if (gun1 == "N")
                            {
                                Console.WriteLine("You Died Of Being Shot Between The Eyes");

                                Console.WriteLine("You Lived Until Day:" + days);
                                Main();
                            }
                            if (gun1 == "Y")
                            {
                                if (hasGun == false)
                                {
                                    Console.WriteLine("You Don't Have A Gun");
                                    Console.WriteLine("You Died Of Being Shot Between The Eyes");

                                    Console.WriteLine("You Lived Until Day:" + days);
                                    Main();
                                }
                                else
                                {
                                    Console.WriteLine("You Have Succesfully Shot The Man You Can Now Continue Shopping");
                                    Console.WriteLine("It Looks Like He Had Some Money On Him");
                                    Console.WriteLine("+$100");
                                    money = money + 100;
                                    shop1();
                                }
                            }
                        }
                        else
                        {
                            shop1();

                        }
                    }
                    else
                    {
                        Console.WriteLine("Failed To Find Shop");
                        restart();
                    }
                }
                void shop1()
                {


                    Console.WriteLine("You Found A Lovely Town With A Shop, Would You Like To Enter? Y/N");
                    string Shop1 = Console.ReadLine();
                    if (Shop1 == "Y")
                    {
                        Console.WriteLine("Welcome To The Shop!");
                        Console.WriteLine("$2 Per LBS of food");
                        Console.WriteLine("Enter How Much Food You Want");
                        Console.WriteLine("");
                        Console.WriteLine("1 - 50 lbs");
                        Console.WriteLine("2 - 250 lbs");
                        Console.WriteLine("3 - 500 lbs");
                        Console.WriteLine("4 - Gun - $300 - This Item Grants You +1 Hunting Level");
                        string food1 = Console.ReadLine();
                        if (money < 100)
                        {
                            Console.WriteLine("You Don't Have Enough Money");
                            restart();
                        }
                        else
                        {
                            if (food1 == "1")
                            {
                                LbsOfFood = LbsOfFood + 50;
                                money = money - 100;
                                restart();
                            }
                            if (food1 == "2")
                            {
                                if (money < 500)
                                {
                                    Console.WriteLine("You Don't Have Enough Money");
                                    shop1();
                                }
                                else
                                {
                                    LbsOfFood = LbsOfFood + 250;
                                    money = money - 500;
                                    restart();
                                }
                            }
                            if (food1 == "3")
                            {
                                if (money < 1000)
                                {
                                    Console.WriteLine("You Don't Have Enough Money");
                                    shop1();
                                }
                                else
                                {
                                    LbsOfFood = LbsOfFood + 500;
                                    money = money - 1000;
                                    restart();
                                }
                            }
                            if (food1 == "4")
                            {
                                if (money < 300)
                                {
                                    Console.WriteLine("You Don't Have Enough Money");
                                    shop1();
                                }
                                else
                                {
                                    hasGun = true;
                                    money = money - 300;
                                    restart();
                                }
                            }
                        }
                    }
                }

                void explore()
                {
                    int explorernd = rnd.Next(1, 5);
                    if (explorernd == 1)
                    {
                        Console.WriteLine("You Have Found A Village Full Of Indians");
                        Console.ReadLine();
                        Console.WriteLine("They Seem Friendly And They Take You To Their Cheif");
                        Console.WriteLine("The Cheif Offers You $200 And A Gun If You Kill The Chief Of Another Tribe");
                        Console.WriteLine("Do You Accept The Offer? Y/N");
                        string Offer1 = Console.ReadLine();
                        if (Offer1 == "N")
                        {
                            restart();
                        }
                        if (Offer1 == "Y")
                        {
                            Console.WriteLine("You Sneak Upon The Enemy Chief, But He Spots You!");
                            Console.WriteLine("Next Thing There Are Several Indians Surrounding You");
                            Console.WriteLine("");
                            Console.WriteLine("You discover a barrel of oil next to them, if you shoot it, there is a 25% chance you will die.");
                            Console.WriteLine("But You Know That It Will Save Your Hidee And It Will Kill The Cheif");
                            Console.WriteLine("Do You Shoot It? Y/N");
                            string Offer2 = Console.ReadLine();
                            if (Offer2 == "N")
                            {
                                restart();
                            }
                            if (Offer2 == "Y")
                            {
                                int explorernd1 = rnd.Next(1, 6);
                                if (explorernd1 == 2)
                                {
                                    Console.WriteLine("You Died From An Exploding Barrel");
                                    Main();
                                }
                                else
                                {
                                    Console.WriteLine("You Kill The Enemy Tribes Cheif And Return To Get Your Reward");
                                    Console.WriteLine("+$200");
                                    Console.WriteLine("+ A Gun (Unless You Already Had One)");
                                    money = money + 200;
                                    hasGun = true;
                                    restart();
                                }
                            }
                        }
                    }
                    if (explorernd == 2)
                    {
                        Console.WriteLine("You Find A Ginormous Wall Of Rock, It Seems To Be A Plateu");
                        Console.WriteLine("You See That There Is A Broken Down Wood Structure");
                        Console.ReadLine();
                        Console.WriteLine("You Spot Some Silvery Coins In It");
                        Console.WriteLine("+$100");
                        money = money + 100;
                        restart();
                    }
                    if (explorernd == 3)
                    {
                        Console.WriteLine("As You Walk You Get Bit In The Foot By A Rattle Snake");
                        Console.WriteLine("Unless You Get Medical Care Soon, You Are A Goner");
                        Console.WriteLine("There Is A Hospital Nearby But It Will Take 40 Pounds Of Food To Get There");
                        Console.WriteLine("Do You Do It? Y/N");
                        String rattle = Console.ReadLine();
                        if (rattle == "N")
                        {
                            Console.WriteLine("You Died From The Rattlesnake Venom Reaching Your Heart");
                            Main();
                        }
                        if (rattle == "Y")
                        {
                            LbsOfFood = LbsOfFood - 40;
                            restart();
                        }
                    }
                    if (explorernd == 4)
                    {
                        Console.WriteLine("You Find A Tribe Of Indians.");
                        Console.WriteLine("These Ones Don't Seem To Like You Very Much");
                        Console.WriteLine("They Say with imperfect english (Unless you give me 300 food, then you get dead) Do you wish to pay them? Y/N");
                        string IndianAnswer = Console.ReadLine();
                        if (IndianAnswer == "Y")
                        {
                            LbsOfFood = LbsOfFood - 300;
                            restart();
                        }
                        else
                        {
                            Console.WriteLine("You died of bleeding from the chest after it was punctered by a spear");
                            Main();
                        }

                    }
                    if (explorernd == 5)
                    {
                        Console.WriteLine("You Seem To Stumble Upon Someone");
                        Console.WriteLine("Hey " + Name + ", Long Time No See");
                        Console.WriteLine("");
                        Console.WriteLine("The Man Seems To Recognize You");
                        Console.WriteLine("That's When You Suddenly Remember This Is Your Friend Garret Back In School A Couple Years Earlier");
                        Console.WriteLine("");
                        Console.WriteLine("You Chat For a While And He Brings You Some Food");
                        Console.WriteLine("(Come Back Anytime Buddy)");
                        Console.WriteLine("You Then Part Ways");
                        Console.WriteLine("+100 LBS of food");
                        LbsOfFood = LbsOfFood + 100;
                        restart();
                    }
                    if (explorernd == 6)
                    {

                    }
                    if (explorernd == 7)
                    {

                    }
                    if (explorernd == 8)
                    {

                    }
                    if (explorernd == 9)
                    {

                    }
                    if (explorernd == 10)
                    {

                    }
                }

                void restart()
                {
                    days = days + 1;
                    if (days == 50)
                    {
                        if (Prof == "Hacker")
                        {
                            Creep();
                        }
                    }
                    LbsOfFood = LbsOfFood - diff;
                    if (LbsOfFood < 1)
                    {
                        Console.WriteLine("You Died Of Starvation");
                        Console.WriteLine("You Lived Until Day:" + days);
                        Main();
                    }
                    if (hasGun == true)
                    {
                        if (hasGun2 == true)
                        {
                            hasGun2 = false;
                            huntChance = huntChance + 1;
                            Console.WriteLine("Your Hunting Experience Has Improved");
                            restart();
                        }
                    }
                    Console.WriteLine("Your Food:" + LbsOfFood + "lbs");
                    Console.WriteLine("Your Money:$" + money);
                    Console.WriteLine("");
                    Console.WriteLine("Continue?");
                    Console.ReadLine();
                    StartOfGame();
                }
                void Creep()
                {
                    Console.WriteLine("YOU HAVE CHOSEN THE WRONG PAT2̷̣̳̈́0̵͕̜̾͑0̵̼͝");
                    Console.WriteLine("YOU HAVE CHOSEN THE WRONG PAT2̷̣̳̈́0̵͕̜̾͑0̵̼͝");
                    Console.WriteLine("YOU HAVE CHOSEN THE WRONG PAT2̷̣̳̈́0̵͕̜̾͑0̵̼͝");
                    Console.WriteLine("YOU HAVE CHOSEN THE WRONG PAT2̷̣̳̈́0̵͕̜̾͑0̵̼͝");
                    Console.WriteLine("YOU HAVE CHOSEN THE WRONG PAT2̷̣̳̈́0̵͕̜̾͑0̵̼͝");
                    Console.WriteLine("YOU HAVE CHOSEN THE WRONG PAT2̷̣̳̈́0̵͕̜̾͑0̵̼͝");
                    Console.WriteLine("YOU HAVE CHOSEN THE WRONG PAT2̷̣̳̈́0̵͕̜̾͑0̵̼͝");
                    Console.WriteLine("YOU HAVE CHOSEN THE WRONG PAT2̷̣̳̈́0̵͕̜̾͑0̵̼͝");
                    restart();
                }

            }
        }
    }
}


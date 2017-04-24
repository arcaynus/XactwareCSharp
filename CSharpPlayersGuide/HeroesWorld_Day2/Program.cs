using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld_Day2
{
    class Program
    {
        static private string[] invalidNames = new[] { "Legolas", "Gandalf", "Frodo", "Bilbo" };

        private enum Statistics
        {
            strength = 0,
            perception,
            endurance,
            charisma,
            intelligence,
            agility,
            luck,
            hitpoints
        };
        public enum Dice { d4 = 5, d6 = 7, d8 = 9, d10 = 11, d00 = 11, d20 = 21 };

        static void Main(string[] args)
        {

            string name = CheckForInvalidNames();
            int[] statistics = new int[Enum.GetNames(typeof(Statistics)).Length];

            // Replace this with Generate Stats Method - Start //
            
            Random random = new Random();


            Console.WriteLine("Rolling your awesome stats...");
            // Generate Stats:
            GenerateStats(random, statistics);

            // Replace this with Generate Stats Method - End //


            Console.WriteLine($"Welcome to HerosWorld (tm): {name}");

            // Create a Display Stats Function - Start //

            // Display Stats

            PrintStatistics(statistics);

            // Create a Display Stats Function - End //


            Console.WriteLine("You encounter an rabid emotionally distant exploding feral deseased lonely slightly overweight kitten");

            int kittenHP = 10;
            while (statistics[(int)Statistics.hitpoints] > 0 || kittenHP > 0)
            {
                Console.WriteLine($"Player HP: {statistics[(int)Statistics.hitpoints]}\nKitten HP: {kittenHP}");
                // Roll for initiative
                var yourRoll = random.Next(1, 21);
                var kittenRoll = random.Next(1, 21);
                if (yourRoll > kittenRoll)
                {
                    //Player attacks first
                    var playerDamage = random.Next(0, 3);
                    kittenHP -= playerDamage;
                    Console.WriteLine($"You hugged the kitten for: {playerDamage}");
                    if (kittenHP <= 0)
                    {
                        break;
                    }
                    //Kitten attacks first
                    var kittenDamage = random.Next(0, 3);
                    statistics[(int)Statistics.hitpoints] -= kittenDamage;
                    Console.WriteLine($"The kitten purred at you and did: {kittenDamage}");
                    if (statistics[(int)Statistics.hitpoints] <= 0)
                    {
                        break;
                    }
                }
                else
                {
                    //Kitten attacks first
                    var kittenDamage = random.Next(0, 3);
                    statistics[(int)Statistics.hitpoints] -= kittenDamage;
                    Console.WriteLine($"The kitten purred at you and did: {kittenDamage}");
                    if (statistics[(int)Statistics.hitpoints] <= 0)
                    {
                        break;
                    }
                    var playerDamage = random.Next(0, 3);
                    kittenHP -= playerDamage;
                    Console.WriteLine($"You hugged the kitten for: {playerDamage}");
                    if (kittenHP <= 0)
                    {
                        break;
                    }
                }
                Console.ReadKey();

            }
            if (statistics[(int)Statistics.hitpoints] < kittenHP)
            {
                Console.WriteLine("Player Lost");
            }
            else
            {
                Console.WriteLine($"{name}: Won the fight");
            }
            Console.ReadKey();
        }

        static string CheckForInvalidNames()
        {
            Console.WriteLine("Please Enter a Character's Name");
            string name = "";

            bool validName = false;
            while (!validName)
            {
                name = Console.ReadLine().Trim();
                foreach (string invalid in invalidNames)
                {

                    if (name.Contains(invalid) || name.Length == 0)
                    {
                        validName = false;
                        if (name.Length == 0)
                        {
                            Console.WriteLine($"You have entered a blank name, please enter a valid name");
                        }
                        else
                        {
                            Console.WriteLine($"You have entered a forbidden name: {invalid}, please enter a valid name");
                        }
                        break;
                    }
                    else
                    {
                        validName = true;
                    }
                }
            }
            return name;
        }

        static int[] GenerateStats(Random random, int[] stats)
        {
            int totalValueMinimum = 35;
            int playerTotalStats = 0;
            int rollCount = 1;

            while (playerTotalStats <= totalValueMinimum)
            {
                //int strength;
                //int perception;
                //int endurance;
                //int charisma;
                //int intelligence;
                //int agility;
                //int luck;
                stats[(int)Statistics.strength] = random.Next(1, 11);
                stats[(int)Statistics.perception] = random.Next(1, 11);
                stats[(int)Statistics.endurance] = random.Next(1, 11);
                stats[(int)Statistics.charisma] = random.Next(1, 11);
                stats[(int)Statistics.intelligence] = random.Next(1, 11);
                stats[(int)Statistics.agility] = random.Next(1, 11);
                stats[(int)Statistics.luck] = random.Next(1, 11);

                // Generate derived stats
                stats[(int)Statistics.hitpoints] = 10 + stats[(int)Statistics.endurance];


                playerTotalStats = GetTotalStats(stats);
                Console.WriteLine($"Roll: {rollCount++} We Rolled a total of: {playerTotalStats}");

            }
            return null;
        }
        public static int GetTotalStats(int[] stats)
        {
            return stats[(int)Statistics.strength] + stats[(int)Statistics.perception] + stats[(int)Statistics.endurance] + stats[(int)Statistics.charisma] + stats[(int)Statistics.intelligence] + stats[(int)Statistics.agility] + stats[(int)Statistics.luck];
        }
        public static int RollDice(Random rand, Dice type)
        {
            return rand.Next(0, (int)type);
        }
        public static void PrintStatistics(int[] stats)
        {
            Console.WriteLine("Your Amazing Base Stats");
            Console.WriteLine("________________________");
            Console.WriteLine($"Strength: {stats[(int)Statistics.strength]}");
            Console.WriteLine($"Perception: {stats[(int)Statistics.perception]}");
            Console.WriteLine($"Endurance: {stats[(int)Statistics.endurance]}");
            Console.WriteLine($"Charisma: {stats[(int)Statistics.charisma]}");
            Console.WriteLine($"Intelligence: {stats[(int)Statistics.intelligence]}");
            Console.WriteLine($"Agility: {stats[(int)Statistics.agility]}");
            Console.WriteLine($"Luck: {stats[(int)Statistics.luck]}");
            Console.WriteLine("________________________");

            Console.WriteLine("Your Amazing Derived Stats");
            Console.WriteLine("________________________");
            Console.WriteLine($"Hit Points: {stats[(int)Statistics.hitpoints]}");
        }
    }
}

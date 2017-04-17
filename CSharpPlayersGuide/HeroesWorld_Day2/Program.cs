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
        enum Statistics
        {
            strength = 0,
            perception,
            endurance,
            charisma,
            intelligence,
            agility,
            luck
        };

        static void Main(string[] args)
        {

            string name = CheckForInvalidNames();
            int[] statistics = new int[Enum.GetNames(typeof(Statistics)).Length];
            
            // Replace this with Generate Stats Method - Start //
            // Statistics
            int strength = 0;
            int perception = 0;
            int endurance = 0;
            int charisma = 0;
            int intelligence = 0;
            int agility = 0;
            int luck = 0;

            // Derived Stats
            int hitpoints = 0;


            int totalValueMinimum = 35;
            int playerTotalStats = 0;
            int rollCount = 1;


            Random random = new Random();
            //int randomNumber = random.Next(0, 100); // This will return integers between 0-99;

            
            Console.WriteLine("Rolling your awesome stats...");
            // Generate Stats:
            while (playerTotalStats <= totalValueMinimum)
            {
                //int strength;
                //int perception;
                //int endurance;
                //int charisma;
                //int intelligence;
                //int agility;
                //int luck;
                strength = random.Next(1, 11);
                perception = random.Next(1, 11);
                endurance = random.Next(1, 11);
                charisma = random.Next(1, 11);
                intelligence = random.Next(1, 11);
                agility = random.Next(1, 11);
                luck = random.Next(1, 11);

                // Generate derived stats
                hitpoints = 10 + endurance;


                playerTotalStats = strength + perception + endurance + charisma + intelligence + agility + luck;
                Console.WriteLine($"Roll: {rollCount++} We Rolled a total of: {playerTotalStats}");

            }

            // Replace this with Generate Stats Method - End //


            Console.WriteLine($"Welcome to HerosWorld (tm): {name}");
            
            // Create a Display Stats Function - Start //

            // Display Stats



            Console.WriteLine("Your Amazing Base Stats");
            Console.WriteLine("________________________");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Perception: {perception}");
            Console.WriteLine($"Endurance: {endurance}");
            Console.WriteLine($"Charisma: {charisma}");
            Console.WriteLine($"Intelligence: {intelligence}");
            Console.WriteLine($"Agility: {agility}");
            Console.WriteLine($"Luck: {luck}");
            Console.WriteLine("________________________");

            Console.WriteLine("Your Amazing Derived Stats");
            Console.WriteLine("________________________");
            Console.WriteLine($"Hit Points: {hitpoints}");

            // Create a Display Stats Function - End //


            Console.WriteLine("You encounter an rabid emotionally distant exploding feral deseased lonely slightly overweight kitten");

            int kittenHP = 10;
            while (hitpoints > 0 || kittenHP > 0)
            {
                Console.WriteLine($"Player HP: {hitpoints}\nKitten HP: {kittenHP}");
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
                    hitpoints -= kittenDamage;
                    Console.WriteLine($"The kitten purred at you and did: {kittenDamage}");
                    if (hitpoints <= 0)
                    {
                        break;
                    }
                }
                else
                {
                    //Kitten attacks first
                    var kittenDamage = random.Next(0, 3);
                    hitpoints -= kittenDamage;
                    Console.WriteLine($"The kitten purred at you and did: {kittenDamage}");
                    if (hitpoints <= 0)
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
            if (hitpoints < kittenHP)
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
            string name="";

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

        static int[] GenerateStats(int [] stats)
        {

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18_Making_Your_Own_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", "J.K. Rowling");

            book.SetTitle("Harry Potter and the Half-Blood Prince"); //Changing the instance's title

            Console.WriteLine($"The book's title is {book.GetTitle()}");

            Random rand = new Random();

            Ball[] ballz = new Ball[10];
            for (int i = 0; i < 10; i++)
            {
                ballz[i] = new Ball(i+1, new Color((byte)rand.Next(0, 256), (byte)rand.Next(0, 256), (byte)rand.Next(0, 256)));
                // Throw each around a random number of times
                var numTimes = rand.Next(1, 25);
                do
                {
                    numTimes--;
                    ballz[i].Throw();
                    //Randomly pop a ball while throwing it
                    if(rand.Next(1,11) >= 7)
                    {
                        //Pop hte ball and break out of throw loop
                        ballz[i].Pop();
                        break;
                    }
                   
                } while (numTimes > 0);
                // Print out the ball
                Console.WriteLine($"Ball[{i}: {ballz[i].ToString()}");
                // Attempt to throw ball again
                Console.WriteLine($"Attempting to throw ball: {i} again...");
                ballz[i].Throw();
                Console.WriteLine($"Ball[{i}: {ballz[i].ToString()}");
            }
            Console.ReadKey();
           

        }
    }
}

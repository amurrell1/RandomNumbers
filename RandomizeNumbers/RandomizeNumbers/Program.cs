using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeNumbers
{
    class Program
    {
        //created the first obj of random above main method and then called next on it
        //static Random obj = new Random(); //seeding from CPU clock
        static void Main(string[] args)
        {
            Console.WriteLine(GetPseudoRandom(2));
            Console.WriteLine(GetPseudoRandom(23));
            Console.WriteLine(GetPseudoRandom(3));
            Console.WriteLine(GetPseudoRandom(5));
            Console.WriteLine(GetPseudoRandom(6));
        }
        //created a static method GetPseudoRandom and had it return an obj to a string.
        private static string GetPseudoRandom(int seed) //creating a seed inside of the method)
        {
            Random obj = new Random(seed);
            return obj.Next(4, 50).ToString();
        }
            /*
            //this is my pseudo random attempt (not really random if you could figure out the see)
            Random random = new Random();
            Console.WriteLine(random.Next());
            */
            /*
            int number = random.Next(1, 13);
            int number2 = random.Next(1000);
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        */
        }
    }



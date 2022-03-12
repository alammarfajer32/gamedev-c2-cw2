using System;

namespace c2_cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "king";
            double characterSpeed = 1.80;
            int age = 40;
            string characterPower = "super speed";
            string characterPower2 = "teleportation";
            int height = 190;
            Console.WriteLine("i am {0}, my speed is {1}, and my age is {2}, my first superpower is {3}, and my second superpower is {4}, and my height is {5}", characterName, characterSpeed, age, characterPower, characterPower2, height);

            string heroName = "rak";
            int heroHeight = 175;
            int heroAge = 20;
            string heroPower1 = "see through walls";
            string heropower2 = "become invisible";
            Console.WriteLine("i am {0}, my height is {1}, and my age is {2}, my two superpowers are {3}, and {4}", heroName, heroHeight, heroAge, heroPower1, heropower2);

            int kingAge = 40;
            int rakAge = 20;
            Console.WriteLine("age Difference is: {0}", kingAge - rakAge);

            int kingHeight = 190;
            int rakHeight = 175;
            Console.WriteLine("height difference is: {0}", kingHeight - rakHeight);
        }
    }
}

using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mangus osaleb 2 mängjat
            //iga mängija viska täringu (1-6)
            //programm kuvab nende visete tulemuse ja kuvab ka, kes on võitja
            // - ehk kes viskas suuremat
            
            Console.WriteLine($"Throw a dice stupid");
            Console.ReadLine();
            Console.WriteLine("Rolling...");
            System.Threading.Thread.Sleep(1000);
            Random rnd = new Random();
            int DiceNumber1 = rnd.Next(1, 6);    
            if (DiceNumber1 == DiceNumber1)
            {
                Console.WriteLine($"stupid threw a {DiceNumber1}");
            }

            
            Console.WriteLine("Throw a dice dumbdumb");
            Console.ReadLine();
            Console.WriteLine("Rolling...");
            System.Threading.Thread.Sleep(1000);
            Random rnd1 = new Random();
            int DiceNumber2 = rnd1.Next(1, 6);
            if (DiceNumber2 == DiceNumber2)
            {
                Console.WriteLine($"dumbdumb threw a {DiceNumber2}");
            }
            
            if (DiceNumber1 > DiceNumber2)
            {
                Console.WriteLine("stupid won, gg. :)");
            }
            else if (DiceNumber1 < DiceNumber2)
            {
                Console.WriteLine("dumbdumb won, gg. :)");
            }
            else if (DiceNumber1 == DiceNumber2)
            {
                Console.WriteLine("y'all tied, gg. :)");
            }
        }
    }
}

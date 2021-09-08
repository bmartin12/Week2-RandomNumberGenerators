using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int MyRandomNumber = rnd.Next(1, 10);
            
            if (MyRandomNumber > 5)
            {
                Console.WriteLine($"Arvuti genereeritud number on {MyRandomNumber}, See on suurem kui 5");
            }
            else if (MyRandomNumber < 5)
            {
                Console.WriteLine($"Arvuti genereeritud number on {MyRandomNumber}, see väiksem kui 5");
            }
            else if(MyRandomNumber == 5)
            {
                Console.WriteLine($"Arvuti genereeritud number ongi {MyRandomNumber}");
            }
            //programm genereerib juhuslikku numbrit 1-10
            //programm kontrollib, kas genereeritud number on suurem, kui 5.
            //kui number on suurem, kui 5. siis konsool kuvab
            //"juhuslik number on {MyRandomNumber}, see on suurem, kui 5";
            //kui number on väiksem, kui 5, konsool kuvab
            //juhuslik number on {MyRandomNumber}, see on väiksem,
            //kui 5";
            //kui number on 5, siis konsool kuvab "juhuslik number on 5"

        }
    }
}

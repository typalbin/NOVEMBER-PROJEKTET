using System;
using System.Collections.Generic;

namespace GolfMasters2021
{
    public class GolfPlayer
    {
        public int age;
        public string name;
        public int averageDriverLength;

        public int driverLength;
        Random generator = new Random();

        List<string> playerNames = new List<string>() {"Tiger Woods", "Dustin Johnsson", "Rory McIlroy"};
        

        public GolfPlayer(){
            averageDriverLength = generator.Next(200,251);
            int randomPlayer = generator.Next(0, playerNames.Count);
            name = playerNames[randomPlayer];
            age = generator.Next(25, 50);
        }

        public void DrawPlayerStats(){
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Ålder: " + age);
            Console.WriteLine("Average Driver Length: " + averageDriverLength);
        }

      
        public void DrawDriverLength(){
            int bajs = generator.Next(1,4);

            if (bajs == 1)
            {
                System.Console.WriteLine("BRA DRIVE, average");
                driverLength = averageDriverLength;
            }

             if (bajs == 2)
             {
                 System.Console.WriteLine("dålig träff");
                 driverLength = generator.Next(averageDriverLength - 40, averageDriverLength - 10);
            }
             if (bajs == 3)
             {
                 System.Console.WriteLine("BÄSTA DRIVEN IDAG???");
                 driverLength = generator.Next(averageDriverLength + 10, averageDriverLength + 40);
            }

            System.Console.WriteLine(driverLength);
        }
        

    }
}

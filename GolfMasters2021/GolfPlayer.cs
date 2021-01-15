using System;
using System.Collections.Generic;

namespace GolfMasters2021
{
    public class GolfPlayer
    {

        //här skapar jag variabler och ger dom namn
        public int age;
        public string name;
        public int averageDriverLength;

        public int driverLength;

        //skapar en random generator som jag sedan använder för att slumpa tal
        Random generator = new Random();

        //skapar en list där jag lagrar namn på spelare som man kan välja i spelet
        List<string> playerNames = new List<string>() {"Tiger Woods", "Dustin Johnsson", "Rory McIlroy", "Nelson Mandela", "Bat Man", "Ernie Els", "Spider Man", "Spindel Mannen"};
        
        //en konstruktor som innehåller själva golfspelaren, den skapar en ny golfspelare och randomizar namn ålder och avarage driver length.
        public GolfPlayer(){
            averageDriverLength = generator.Next(200,251);
            int randomPlayer = generator.Next(0, playerNames.Count);
            name = playerNames[randomPlayer];
            age = generator.Next(25, 50);
        }

        //den här metoden skriver ut spelarens stats
        public void drawPlayerStats(){
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Ålder: " + age);
            Console.WriteLine("Average Driver Length: " + averageDriverLength);
        }

      
        //har skapar jag en metod som räknar ut hur långt varje spelare som är med i spelet slår bollen
        public void drawDriverLength(){
            int player = generator.Next(1,4);

            if (player == 1)
            {
                System.Console.WriteLine("Helt Okej drive :/");
                driverLength = averageDriverLength;
            }

             if (player == 2)
             {
                 System.Console.WriteLine("Dålig träff :(");
                 driverLength = generator.Next(averageDriverLength - 40, averageDriverLength - 10);
            }
             if (player == 3)
             {
                 System.Console.WriteLine("Grym Träff!");
                 driverLength = generator.Next(averageDriverLength + 10, averageDriverLength + 40);
            }

            System.Console.WriteLine(driverLength);
        }
        

    }
}

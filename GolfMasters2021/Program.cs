using System;
using System.Collections.Generic;

namespace GolfMasters2021
{
    class Program
    {
        static void Main(string[] args)
        {

            // skapar instanser av klassen
           GolfPlayer player1 = new GolfPlayer();
           GolfPlayer player2 = new GolfPlayer();

           //skapar variabler

           bool seeStats = false;

           string playerChoice;

           int playerGuess = 0;

           bool choice = false;

            //här börjar själva interaktionen med spelet
           System.Console.WriteLine("Välkommen till årets long driving tävling som hålls här på Bro Hof GK");
           System.Console.WriteLine("Ditt uppdrag är att gissa vem som vinner genom att se på spelarnas stats och gissa vem som vinner.");
           Console.ReadLine();
           System.Console.WriteLine("Skriv !stats för att se stats :)");


            // en loop som körs tills man skriver !stats.
           while(seeStats == false)
        { 
                if (Console.ReadLine() == "!stats")
                {

                    // här får man se spelares stats
                player1.drawPlayerStats();
                player2.drawPlayerStats();
                Console.ReadLine();

                seeStats = true;
            }

           else
           {
               System.Console.WriteLine("är du säker att du inte vill se stats? Skriv !stats .");
           }
        }



            //här gissar man antingen på spelare 1 eller 2
            while(choice == false)
            {
                
                System.Console.WriteLine("gissa på en spelare, 1 eller 2");
            
                playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    System.Console.WriteLine("du har gissat på spelare 1");

                    choice = true;
                    playerGuess = 1;
                }

                else if (playerChoice == "2")
                {
                    System.Console.WriteLine("du har gissat på spelare 2");

                    choice = true;
                    playerGuess = 2;
                }

                else {
                    System.Console.WriteLine("Lek inte ball nu, gissa på antingen spelare 1 eller 2");
                    playerGuess = 0;
                }

            }

            Console.ReadLine();

            Console.Clear();

            //konsollen clearas och man får se spelarnas Drives och sen ser man om man vinner eller inte
            System.Console.WriteLine("Nu kör spelarna");
            System.Console.WriteLine("Tryck ENTER för att se resultaten");
            Console.ReadLine();

            //här skrivs resultaten ut, tillsammans med om det va en bra eller dålig träff.

            player1.drawDriverLength();
            player2.drawDriverLength();

            Console.ReadLine();
            

          if(playerGuess == 1)
          {
              if (player1.driverLength > player2.driverLength )
              {
               System.Console.WriteLine("Du gissade rätt, du vinner 100 000kr");
               }

               else{
                   System.Console.WriteLine("Du förlora");
               }
               
          }

            if(playerGuess == 2)
          {
              if (player1.driverLength < player2.driverLength )
              {
               System.Console.WriteLine("Du gissade rätt, du vinner 100 000 kr");
               }

               else{
                   System.Console.WriteLine("Du förlora");
               }
               
          }

            Console.ReadLine();
        
        }
    }
}

using System;
using System.Collections.Generic;

namespace GolfMasters2021
{
    class Program
    {
        static void Main(string[] args)
        {
           GolfPlayer player1 = new GolfPlayer();
           GolfPlayer player2 = new GolfPlayer();

           bool seeStats = false;

           string playerChoice;

           int playerGuess = 0;

           bool choice = false;

           System.Console.WriteLine("jalla lägg den");
           System.Console.WriteLine("skriv !stats för att se stats");

           while(seeStats == false)
        { 
                if (Console.ReadLine() == "!stats")
                {
                player1.DrawPlayerStats();
                player2.DrawPlayerStats();
                Console.ReadLine();

                seeStats = true;
            }

           else
           {
               System.Console.WriteLine("är du säker att du inte vill se stats? Skriv !stats .");
           }
        }


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
                    System.Console.WriteLine("ey din dummer gissa på en legitim siffra kahbe");
                    playerGuess = 0;
                }

            }

            Console.ReadLine();

            Console.Clear();

            System.Console.WriteLine("Nu kör spelarna");
            Console.ReadLine();

            player1.DrawDriverLength();
            player2.DrawDriverLength();
            

          if(playerGuess == 1)
          {
              if (player1.driverLength > player2.driverLength )
              {
               System.Console.WriteLine("du gissa rätt");
               }

               else{
                   System.Console.WriteLine("du lose");
               }
               
          }

            if(playerGuess == 2)
          {
              if (player1.driverLength < player2.driverLength )
              {
               System.Console.WriteLine("du gissa rätt");
               }

               else{
                   System.Console.WriteLine("du lose");
               }
               
          }




           // player1.DrawPlayerStats();
           // player2.DrawPlayerStats();


           // player1.DrawDriverLength();
           // player2.DrawDriverLength();

           // if (player1.driverLength > player2.driverLength ){
              //  System.Console.WriteLine("player 1 vinner");

           // }
//
           // else{
           //     System.Console.WriteLine("player 2 vinner");
           // }

            Console.ReadLine();
        
        }
    }
}

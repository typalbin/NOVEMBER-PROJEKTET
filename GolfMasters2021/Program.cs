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

            player1.DrawPlayerStats();
            player2.DrawPlayerStats();


            player1.DrawDriverLength();
            player2.DrawDriverLength();

            if (player1.driverLength > player2.driverLength ){
                System.Console.WriteLine("player 1 vinner");

            }

            else{
                System.Console.WriteLine("player 2 vinner");
            }

            Console.ReadLine();
        }
    }
}

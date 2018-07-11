/*
 * A text based game
 * Patrick Klokgieters 30-5-18
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_App {
    class Program {

        //Start of program, call needed functions & Shows Title.
        static void Main() {
            Console.Title = "Nuclear Prison";
            Game.StartGame();
            Console.ReadKey();
        }
    }
}
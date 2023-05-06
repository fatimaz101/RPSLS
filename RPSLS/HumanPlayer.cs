using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override void ChooseGesture()
        {
            Console.WriteLine($"Okay {name}, choose a gesture.Pick from here");
            Console.WriteLine($"{gestures[0]}, {gestures[1]}, {gestures[2]},{ gestures[3]}, {gestures[4]}");
            
            Console.WriteLine("Make sure you have the right spelling!");
            
            chosenGesture = Console.ReadLine();
           
            
        }
    }
}

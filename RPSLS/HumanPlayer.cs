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
            Console.WriteLine($"Okay {name}, choose a gesture.Here are your options");
            Console.WriteLine(gestures);
            Console.WriteLine("Make sure you have the right spelling!");
            
            chosenGesture = Console.ReadLine();
           
            
        }
    }
}

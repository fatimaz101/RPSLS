using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(string name) : base(name)
        {
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("My turn!");
            Random rand = new Random();
            int index = rand.Next(gestures.Count);
            chosenGesture = gestures[index];
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAnoula.Models
{
    class Door : Mandalos
    {
        public void BigDOr()
        {
            Console.WriteLine("To spiti exei stin eisodo toy mia megali porta");
        }
        public void OpenDoor()
        {
            Console.Write("anoigei tin porta");
        }
        public void CloseDoor()
        {
            Console.Write("kleinei tin porta");
        }
    }
}

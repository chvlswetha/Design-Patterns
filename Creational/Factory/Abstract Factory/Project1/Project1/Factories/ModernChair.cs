using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Factories
{
    public class ModernChair : Chair
    {
        public void sitChair()
        {
            Console.WriteLine("Sitting on Modern Chair");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Factories
{
    public class ModernTable: Table
    {
        public void placeTable()
        {
            Console.WriteLine("Dinning on Modern Table");
        }
    }
}

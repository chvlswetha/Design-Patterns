using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Factories
{
    public class TraditionalSofa : Sofa
    {
        public void sitSofa()
        {
            Console.WriteLine("Sitting on Traditional Sofa");
        }
    }
}

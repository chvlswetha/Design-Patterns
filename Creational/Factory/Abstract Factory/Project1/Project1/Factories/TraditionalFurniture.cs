using Project1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Factories
{
    public class TraditionalFurniture : FurnitureFactory
    {
        public Sofa CreateSofa()
        {
            return new TraditionalSofa();
        }
        public Chair CreateChair()
        {
            return new TraditionalChair();
        }
        public Table CreateTable()
        {
            return new TraditionalTable();
        }
    }
}

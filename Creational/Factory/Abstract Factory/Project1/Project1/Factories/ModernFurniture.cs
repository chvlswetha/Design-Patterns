using Project1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Factories
{
    public class ModernFurniture : FurnitureFactory
    {

        public Sofa CreateSofa()
        {
            return new ModernSofa();
        }
        public Chair CreateChair()
        {
            return new ModernChair();
        }
        public Table CreateTable()
        {
            return new ModernTable();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces; 

namespace Project1.Factories
{
 
    //Abstract factory - Factory of Factories.
    public interface FurnitureFactory
    {
        Sofa CreateSofa();
        Table CreateTable();

        Chair CreateChair();

        public static FurnitureFactory CreateFurniture(string type)
        {
            if (type.Equals("traditional"))
            {
                return new TraditionalFurniture();
            }
            else if (type.Equals("modern"))
                return new ModernFurniture();
            else
                return null;
        }
    }
}

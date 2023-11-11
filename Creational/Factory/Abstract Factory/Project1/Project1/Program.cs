using System;
using Project1.Factories;
using Project1.Interfaces;

class Main_Client
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter Input: traditional/modern ? : " );
        string type = Console.ReadLine();
        FurnitureFactory input = FurnitureFactory.CreateFurniture(type);
       

        Chair tchair = input.CreateChair();
        Table ttable = input.CreateTable();
        Sofa tsofa = input.CreateSofa();

        tchair.sitChair();
        ttable.placeTable();
        tsofa.sitSofa();
    }
}
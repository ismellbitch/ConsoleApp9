using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название алмаза: ");
            string name = Console.ReadLine();
            Console.Write("Введите цвет алмаза: ");
            string color = Console.ReadLine();
            Console.Write("Введите вес алмаза: ");
            double weigth = double.Parse(Console.ReadLine());
            Console.Write("Введите качество огранки алмаза в баллах: ");
            int facetingQuality = int.Parse(Console.ReadLine());

            if (color == "голубой") { Diamond diamond = new BlueDiamond(name, color, weigth, facetingQuality); Console.WriteLine(diamond.GetDiamondQuality()); }
            else if (color == "жёлтый" || color == "желтый") { Diamond diamond = new YellowDiamond(name, color, weigth, facetingQuality); Console.WriteLine(diamond.GetDiamondQuality()); }
            else { Diamond diamond = new Diamond(name, color, weigth, facetingQuality); Console.WriteLine(diamond.GetDiamondQuality()); }
        }
    }
}
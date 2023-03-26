using System;
using static System.Net.Mime.MediaTypeNames;

namespace PW4_3
{
    class Orc
    {
        public string Name;
        private static int OrcQuantity = 0;
        private static int AmountOfGoldCarried = 100;
        private static int TotalGold = 0;
        public Orc(string Name)
        {
            this.Name = Name;
        }
        
        public void GoldIncrease()
        {
            OrcQuantity++;
            AmountOfGoldCarried += 2;
            if (OrcQuantity > 5)
            {
                TotalGold += AmountOfGoldCarried - 2;
                Console.WriteLine($"Орк {Name} присоединился к отряду, он должен нести {AmountOfGoldCarried} золота, но переносит {AmountOfGoldCarried - 2} золота, так как 2 золота присвоил себе. Общее количество переносимого золота - {TotalGold}");
            }
            else
            {
                TotalGold += AmountOfGoldCarried;
                Console.WriteLine($"Орк {Name} присоединился к отряду, он переносит {AmountOfGoldCarried} золота. Общее количество переносимого золота - {TotalGold}");
            }
        }
    }
    class program
    {
        static void Main()
        {
            Orc orc1 = new Orc("Гаррош");
            Orc orc2 = new Orc("Тралл");
            Orc orc3 = new Orc("Громмаш");
            Orc orc4 = new Orc("Каргат");
            Orc orc5 = new Orc("Дуротан");
            Orc orc6 = new Orc("Гром'гол");
            Orc orc7 = new Orc("Маннорот");
            Orc orc8 = new Orc("Гул'дан");
            
            orc1.GoldIncrease();
            orc2.GoldIncrease();
            orc3.GoldIncrease();
            orc4.GoldIncrease();
            orc5.GoldIncrease();
            orc6.GoldIncrease();
            orc7.GoldIncrease();
            orc8.GoldIncrease();
        }
    }
}
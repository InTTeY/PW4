using System;
using System.Security.Cryptography.X509Certificates;

namespace PW4_1
{
    class MagicPotion
    {
        private string Name;
        public int MagicPoint;
        public MagicPotion(string name, int magicPoint)
        {
            Name = name;
            MagicPoint = magicPoint;
        }
        public void UsePotion()
        {
            Console.WriteLine($"Использовано {Name} x1, оно прибавило {MagicPoint} очков маны вашему персонажу");
        }
    }
    class MagicSpell
    {
        private string Name;
        public int MagicCost;
        private string Effect;
        private int MagicDamage;
        public MagicSpell (string name, int magicCost, string effect, int magicDamage)
        {
            Name = name;
            MagicCost = magicCost;
            Effect = effect;
            MagicDamage = magicDamage;
        }
        public void UseMagicSpell()
        {
            Console.Write($" использует заклинание {Name}, затратив {MagicCost} единиц маны. Эффект от заклинания - {Effect}, нанёс противнику {MagicDamage} единиц урона.");
        }
        public void ErrorUseMagicSpell()
        {
            Console.Write($" пытается использовать заклинание {Name}. ");
        }
    }
    class Characters
    {
        public string Name;
        public int MagicPoint;

        public Characters(string name, int magicPoint)
        {
            Name = name;
            MagicPoint = magicPoint;
        }
        public void CastMagicSpell(MagicSpell MagicSpell, MagicPotion MagicPotion)
        {
            if (MagicPoint>= MagicSpell.MagicCost)
            {
                Console.Write($"Персонаж {Name}");
                MagicSpell.UseMagicSpell();
                Console.WriteLine();
                MagicPoint-= MagicSpell.MagicCost;
            }
            else
            {
                while (MagicPoint < MagicSpell.MagicCost)
                {
                    Console.Write($"Персонаж {Name}");
                    MagicSpell.ErrorUseMagicSpell();
                    int LackMagicPoint = MagicSpell.MagicCost - MagicPoint;
                    Console.Write($"Не хватает {LackMagicPoint} единиц маны. Выпейти зелье!");
                    Console.WriteLine();
                    MagicPotion.UsePotion();
                    Console.WriteLine();
                    MagicPoint = MagicPoint + MagicPotion.MagicPoint;
                }
                Console.Write($"Персонаж {Name}");
                MagicSpell.UseMagicSpell();
                Console.WriteLine();
                MagicPoint -= MagicSpell.MagicCost;
            }
        }
    }
    class program
    {
        static void Main()
        {
            MagicSpell Firebolt = new MagicSpell("Огненная стрела", 41, "Выстрел сгустка огня", 25);
            MagicSpell Fireball = new MagicSpell("Огненный шар", 133, "Выстрел взрывающегося сгустка огня", 40);
            MagicPotion SmallPotion = new MagicPotion("Слабое зелье магии", 25);
            Characters DragonBorn = new Characters("Довакин", 120);

            DragonBorn.CastMagicSpell(Firebolt, SmallPotion);
            DragonBorn.CastMagicSpell(Fireball, SmallPotion);

            Console.ReadKey( true );
        }
    }
}
using System;
using System.Collections.Specialized;

namespace PW4_2
{
    class Package
    {
        public string description;
        public int weight;
        public Package(string description, int weight)
        {
            this.description = description;
            this.weight = weight;
        }
        public void Send()
        {
            Console.WriteLine($"Отправлена посылка ({description}), её вес - {weight} кг.");
        }
        public void SendError()
        {
            Console.WriteLine($"Посылка ({description}) не отправлена, так как превышен лимит общего веса отправлений");
        }
    }
    class DispatchService
    {
        public int WeightLimit = 0;
        public void SendPackage(Package package)
        {
            if (WeightLimit < 50)
            {
                package.Send();
                WeightLimit += package.weight;
            }
            else
            {
                package.SendError();
                return;
            }
        }
    }
    class program
    {
        static void Main()
        {
            Package package1 = new Package("Телевизор", 10);
            Package package2 = new Package("Монитор", 6);
            Package package3 = new Package("Минихолодильник", 15);
            Package package4 = new Package("Стиральная машина", 30);
            Package package5 = new Package("Стол", 8);

            DispatchService dispatchService = new DispatchService();

            dispatchService.SendPackage(package1);
            dispatchService.SendPackage(package2);
            dispatchService.SendPackage(package3);
            dispatchService.SendPackage(package4);
            dispatchService.SendPackage(package5);

            Console.ReadKey(true);
        }
    }
}
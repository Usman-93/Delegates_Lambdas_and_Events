using System;
using System.Collections.Generic;

namespace Lesson2
{
    public class Developer
    {
        public delegate bool IsPromote(Developer developer);
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public int NumberOfClients { get; set; }

        public static void PromoteDeveloper(List<Developer> developerList, IsPromote ShallPromote)
        {
            foreach (Developer developer in developerList) 
            {
                if (ShallPromote(developer))
                {
                    Console.WriteLine($"{developer.Name} is promoted");
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Lesson2;
using static Lesson2.Developer;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Developer> developers= new List<Developer>();
            developers.Add(new Developer() { ID = 1, Name = "Usman Rahat", Salary = 100, Experience = 3, NumberOfClients = 7  });
            developers.Add(new Developer() { ID = 1, Name = "John Adam", Salary = 150, Experience = 13, NumberOfClients = 20 });

            IsPromote isPromotable = new IsPromote(Promote);

            Developer.PromoteDeveloper(developers, isPromotable);

            Console.ReadLine();
        }

        public static bool Promote(Developer developer) 
        {
            return (developer.Experience > 2 && developer.Salary > 90);
        }
    }
}

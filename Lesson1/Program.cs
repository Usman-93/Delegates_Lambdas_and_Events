using System;

namespace Lesson1
{
    public delegate void DelPointer(string value);
    internal class Program
    {

        static void Main(string[] args)
        {
            DelPointer del = new DelPointer(Greeting);

            del("Usman Rahat");

            Console.ReadLine();
        }
        public static void Greeting(string firstName)
        {
            Console.WriteLine($"Hello {firstName}");
        }
    }


}

using System;

namespace PracticeCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeCoreConsole.Practice.Program1 Prog1;
            Prog1 = new PracticeCoreConsole.Practice.Program1();

            Prog1.Test();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}

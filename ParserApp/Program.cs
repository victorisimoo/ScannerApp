using System;

namespace ParserApp {
    class Program {
        static void Main(string[] args)
        {
            string regexp = Console.ReadLine();
            Parser parser = new Parser();
            parser.Parse(regexp);
            Console.WriteLine("Expresion OK");
            Console.ReadLine();

        }
    }
}

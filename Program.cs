using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("my first code");
            Console.WriteLine("my second code");
            Console.WriteLine($"change on branch - {new fooClass().GetAString()}");
            Console.ReadLine();
        }
    }
}
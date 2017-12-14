using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 10000; i++) { 
                Console.WriteLine($"{i} - Time is - {new fooClass().GetAString()}");              
            }
            Console.ReadLine();
        }
    }
}
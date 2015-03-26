using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Javascript!");
            var random = new Random();
            int n = random.Next();
            Console.WriteLine("{0} is a randomly generated {1}", n, n.GetType());
            int log = (int)Math.Floor( Math.Log10( Math.Abs(n) ) );
            Console.WriteLine("Floor(Log10(|{0}|)) = {1}.", n, log);
        }
    }
}

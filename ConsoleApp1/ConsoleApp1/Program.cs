namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, MutablePoint>();
            dict["a"] = new MutablePoint { X = 5 };
            var p1= dict["a"];
            dict["a"].X = 100;   // ⚠️ السطر المدان

            Console.WriteLine(dict["a"].X);   // هيطبع إيه؟

        }
        public class MutablePoint
        {
            public int X;
        }

        
    }
}

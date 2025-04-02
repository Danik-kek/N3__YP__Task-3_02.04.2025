namespace N3__YP__Task_3_02._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter sum");
            float.TryParse(Console.ReadLine(), out float x);
            if ( x < 100) { Console.WriteLine($"ваш счет {x + x * 0.05}"); }
            else if (x > 100 && x < 200) { Console.WriteLine($"ваш счет{x + x*0.07}"); }
            else { Console.WriteLine($"ваш счет{x + x * 0.1}"); }
        }
    }
}

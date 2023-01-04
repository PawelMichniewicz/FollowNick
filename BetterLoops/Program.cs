namespace BetterLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boring and bad performance
            //foreach (var item in Enumerable.Range(1,10))
            //{
            //    Console.WriteLine(item);
            //}

            // cool and fancy like Kotlin
            foreach (var item in 5..13)
            {
                Console.WriteLine(item);
            }
        }
    }
}
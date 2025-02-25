namespace cicaaaaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cicaaa c1 = new("Rozi", 9, 8, "házi macska", "cirmos", 15, 5, "nőstény");
            Cicaaa c2 = new("Csizmás Kandúr", 3, 4, "házi macska", "narancssárga", 70, 4, "kandúr");
            Cicaaa c3 = new("Cirmi", 4, 9, "Maine Coon", "fehér", 40, 7, "nőstény");

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}

namespace Topic_4._5___Methods_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER for a joke:");
            Console.ReadLine();
            Joke();
        }

        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run in again,");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code");
        }


    }
}

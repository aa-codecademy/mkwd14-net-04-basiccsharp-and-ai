namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(SayHello("Risto"));
        }

        public static string SayHello(string name)
        {
            string result = $"Hello there {name}!";
            return result;
        }
    }
}

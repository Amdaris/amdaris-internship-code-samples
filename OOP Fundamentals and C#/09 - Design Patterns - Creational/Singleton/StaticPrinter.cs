namespace Singleton
{
    public class StaticPrinter : IPrinter
    {
        private static readonly StaticPrinter _instance = new StaticPrinter();

        static StaticPrinter()
        {
        }

        private StaticPrinter()
        {
        }

        public static StaticPrinter Instance
        {
            get => _instance;
        }

        public void Print(string text)
        {
            if (text.Length > 10)
            {
                Task.Delay(2000).Wait();
            }

            Console.WriteLine($"Printing: {text} using instance with hash code {this.GetHashCode()}");
        }
    }
}

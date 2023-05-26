namespace Singleton
{
    public class Printer : IPrinter
    {
        private static Printer _instance;

        private Printer()
        {
        }

        public static Printer Instance
        {
            get
            {
                // Console.WriteLine($"1. Thread id: {Environment.CurrentManagedThreadId}");
                if (_instance == null)
                {
                    // Console.WriteLine($"2. Thread id: {Environment.CurrentManagedThreadId}");
                    _instance = new Printer();
                }

                return _instance;
            }
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

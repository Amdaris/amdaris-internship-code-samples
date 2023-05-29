namespace Singleton
{
    public class SafePrinter : IPrinter
    {
        private static SafePrinter _instance;
        private static readonly object padlock = new object();

        private SafePrinter()
        {
        }

        public static SafePrinter Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SafePrinter();
                        }
                    }
                }

                return _instance;
            }
            private set { }
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

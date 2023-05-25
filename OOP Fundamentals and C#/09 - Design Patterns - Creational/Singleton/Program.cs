using Singleton;

// TestSingleton();
TestMultipleThreadsSingleton();

Console.ReadLine();



static void TestSingleton()
{
    // var instance0 = new Printer();

    var instance1 = Printer.Instance;
    var instance2 = Printer.Instance;
    var instance3 = Printer.Instance;

    instance1.Print("instance1");
    instance2.Print("instance2");
    instance3.Print("Some longer text using instance3");

    Console.WriteLine("Are all our instances the same?");
    Console.WriteLine(instance1 == instance2 && instance2 == instance3);

    Console.WriteLine("What's the hash code of our instances?");
    Console.WriteLine($"instance1: {instance1.GetHashCode()}");
    Console.WriteLine($"instance2: {instance2.GetHashCode()}");
    Console.WriteLine($"instance3: {instance3.GetHashCode()}");
}

static void TestMultipleThreadsSingleton()
{
    var printerClients = new List<string>() { "text1", "text2", "text3", "text4", "some longer text 5" };

    Parallel.ForEach(printerClients, new ParallelOptions { MaxDegreeOfParallelism = 5 }, printerClient =>
    {
        // Printer.Instance.Print(printerClient);
        SafePrinter.Instance.Print(printerClient);
    });
}





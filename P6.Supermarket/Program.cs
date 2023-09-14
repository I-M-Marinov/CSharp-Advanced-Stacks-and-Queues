string input = Console.ReadLine();

Queue<string> customerQueue = new Queue<string>();

while (input != "End")
{
    if (input != "Paid" && input != "End")
    {
        customerQueue.Enqueue(input);
    }
    else if (input == "Paid")
    {
        while (customerQueue.Count > 0)
        {
            Console.WriteLine($"{customerQueue.Dequeue()}");
        }
    }

    input = Console.ReadLine();

    if (input == "End")
    {
        Console.WriteLine($"{customerQueue.Count} people remaining.");
    }
}


using System.Reflection.Metadata;

Queue<string> children = new Queue<string>(Console.ReadLine().Split());

int tossCount = int.Parse(Console.ReadLine());
int tosses = 0;
while (children.Count > 1)
{
    string childWithPotato = children.Dequeue();
    tosses++;

    if (tosses == tossCount)
    {
        tosses = 0;
        Console.WriteLine($"Removed {childWithPotato}");
    }
    else
    {
        children.Enqueue(childWithPotato);
    }
}

Console.WriteLine($"Last is {children.Dequeue()}");




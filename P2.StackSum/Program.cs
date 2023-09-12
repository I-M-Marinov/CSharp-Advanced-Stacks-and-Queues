
List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

Stack<int> stack = new Stack<int>(input);

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] split = command .Split(' ');
    if (command.Contains("add"))
    {
        int first = int.Parse(split[1]);
        int second = int.Parse(split[2]);
        stack.Push(first);
        stack.Push(second);
    }
    else if (command.Contains("remove"))
    {
        int n = int.Parse(split[1]);
        if (n <= stack.Count)
        {
            for (int i = 0; i < n; i++)
            {
                stack.Pop();
            }
        }
    }
    command = Console.ReadLine().ToLower();
}
int sum = 0;

while (stack.Count > 0)
{
    sum += stack.Pop();
}
Console.WriteLine($"Sum: {sum}");
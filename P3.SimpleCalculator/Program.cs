
List<string> input = Console.ReadLine().Split().Reverse().ToList();

Stack<string> tokensStack = new Stack<string>();    
int currentResult = 0;

foreach (var token in input)
{
    tokensStack.Push(token);
}

currentResult = int.Parse(tokensStack.Pop());

while (tokensStack.Count > 0)
{
    

    if (tokensStack.Peek() == "+")
    {
            tokensStack.Pop();
            int nextNumber = int.Parse(tokensStack.Pop());
            currentResult += nextNumber;

            if (tokensStack.Count == 0)
            {
                break;
            }
    }

    if (tokensStack.Peek() == "-")
    {
            tokensStack.Pop();
            int nextNumber = int.Parse(tokensStack.Pop());
            currentResult -= nextNumber;

            if (tokensStack.Count == 0)
            {
                break;
            }
    }

}

Console.WriteLine($"{currentResult}");

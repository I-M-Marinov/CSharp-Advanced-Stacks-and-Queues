int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> numbersQueue = new Queue<int>();
Queue <int> oddNumbersQueue = new Queue<int>();

for (int i = 0; i < inputNumbers.Length; i++)
{
    numbersQueue.Enqueue(inputNumbers[i]);
}

while (numbersQueue.Count > 0)
{

    if (numbersQueue.Peek() % 2 == 0)
    {
        oddNumbersQueue.Enqueue(numbersQueue.Dequeue());
    }
    else
    {
        numbersQueue.Dequeue();
    }

    if (numbersQueue.Count == 0)
    {
        break;
    }
}
Console.WriteLine(string.Join(", ", oddNumbersQueue));


// store n ints

List<int> numbers = new List<int>();

numbers.Add(10);
numbers.Add(20);


for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach (int item in numbers)
{
    Console.WriteLine(item);
}

Console.WriteLine(numbers[1]);

numbers.Insert(10, 1000);
numbers.RemoveAt(10);
numbers.Sort();



Queue<int> q = new Queue<int>();
q.Enqueue(10); // add
q.Dequeue(); // read and delete
q.Peek(); // reads

Stack<int> stack = new Stack<int>();
stack.Push(10); // adds

stack.Pop(); // reads and deletes

stack.Peek(); // reads

HashSet<int> hs = new HashSet<int>(); // similar to list
hs.Add(10);
hs.Add(10); // doesnt store

Dictionary<int, string> results = new Dictionary<int, string>();
results.Add(111, "Pass");
results.Add(222, "Fail");

string r = results[222]; //reads value at key
using System.Collections;


Console.WriteLine("Generic");

List<string> names = new List<string>();

Console.WriteLine("List:");

names.Add("Faysal");
names.Add("Touhid");
names.Add("Omor");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Dictionary<string, int> persons = new Dictionary<string, int>();

Console.WriteLine("Dictionary:");

persons.Add("Faysal", 27);
persons.Add("Omor", 25);

persons["Faysal"]  = 27;

Console.WriteLine(persons["Faysal"]);

HashSet<string> items = new HashSet<string>();

Console.WriteLine("HashSet:");

items.Add("Faysal");
items.Add("Faysal");
items.Add("Omor");
items.Add("Omor");

foreach (var item in items)
{
    Console.WriteLine(item); 
}

Stack<string> stack = new Stack<string>();

Console.WriteLine("Stack:");
stack.Push("One");
stack.Push("Two");
stack.Push("Three");
stack.Push("Four");
stack.Push("Five");

var count = stack.Count;
for (int i = 0; i < count; i++)
{
    Console.WriteLine(stack.Pop());
}

Queue<int> queue = new Queue<int>();

Console.WriteLine("Queue:");

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(queue.Dequeue());
}

SortedList<string, int> sortedList = new SortedList<string, int>();

Console.WriteLine("SortedList:");

sortedList.Add("Faysal", 27);
sortedList.Add("Omor", 25);
sortedList.Add("Fahad", 23);

foreach (var item in sortedList)
{
    Console.WriteLine($"key: {item.Key} , Value; {item.Value}");
}

LinkedList<string> list = new LinkedList<string>();

Console.WriteLine("LinkedList:");

list.AddLast("One");
list.AddLast("Two");
list.AddLast("Three");

foreach (var item in list)
{
    Console.WriteLine(item);
}


Console.WriteLine("Non-Generic");

ArrayList arrayList = new ArrayList();

Console.WriteLine("ArrayList:");

arrayList.Add("One");
arrayList.Add(2);
arrayList.Add(3.0);
arrayList.Add(true);

Stack stack1 = new Stack();

Queue queue1 = new Queue();

Hashtable hashtable = new Hashtable();
hashtable.Add("Faysal", 27);
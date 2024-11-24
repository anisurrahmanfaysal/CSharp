using GenericsExample;

Coordinate<int, double> c = new Coordinate<int, double>();
c.X = 5;
c.Y = 9;

BubbleSort bubbleSort1 = new BubbleSort();

var result = bubbleSort1.Sort(new int[] {3,6,6,3,4,});

foreach (var item in result)
{
    Console.WriteLine(item);
}
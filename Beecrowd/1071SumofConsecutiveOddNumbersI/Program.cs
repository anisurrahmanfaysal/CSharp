var startNumber = int.Parse(Console.ReadLine());
var endNumber = int.Parse(Console.ReadLine());
int count = 0;

if(startNumber > endNumber)
{
    var temp = startNumber;
    startNumber = endNumber;
    endNumber = temp;
}

for (int i = startNumber + 1; i < endNumber; i+=1)
{
    if(i%2 != 0)
        count += i;
}

Console.WriteLine(count);
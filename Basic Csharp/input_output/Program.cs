Console.WriteLine("Your Code is runing");
// Read int data.
Console.WriteLine("Enter a Number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);

// Read string data
Console.WriteLine("Enter a Line");
string latter = Console.ReadLine();
Console.WriteLine(latter);

// Remove whait space

string[] partOfLine = latter.Split(' ');
foreach (var item in partOfLine)
{
    Console.WriteLine(item);
}

// binary "And" operator & and binary value print 

uint a = 0b_1111_1000;
uint b = 0b_1111_1000;
uint c = a & b;
Console.WriteLine(Convert.ToString(c, toBase:2));

// binary "Or" operator & and binary value print 

uint a1 = 0b_1011_1000;
uint b2 = 0b_1011_0000;
uint c1 = a1 | b2;
Console.WriteLine(Convert.ToString(c1, toBase:2));

// X-or operation

uint z = a ^ b;
Console.WriteLine(Convert.ToString(z, toBase:2));



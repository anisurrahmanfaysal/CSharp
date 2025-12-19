string[] input = Console.ReadLine().Split(' ');

int code = int.Parse(input[0]);
int quentity = int.Parse(input[1]);

double price = 0.00;
if (code == 1)
    price = 4.00;
else if (code == 2)
    price = 4.50;
else if (code == 3)
    price = 5.00;
else if (code == 4)
    price = 2.00;
else if (code == 5)
    price = 1.50;

Console.WriteLine($"Total: R$ {price*quentity:F2}");

//double SetPrice(int code)
//{
//    if (code == 1)
//        price = 4.00;
//    else if (code == 2)
//        price = 4.50;
//    else if (code == 3)
//        price = 5.00;
//    else if (code == 4)
//        price = 2.00;
//    else if (code == 5)
//        price = 1.50;
//    return price;
//}
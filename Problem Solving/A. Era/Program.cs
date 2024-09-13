// See https://aka.ms/new-console-template for more information
Console.Write("Number of Array :");

int numberOfArray = int.Parse(Console.ReadLine());      //Input Number of array = 4

for (int i = 0; i < numberOfArray; i++)
{
    Console.Write("Number of Array Elements :");

    int arrayElement = int.Parse(Console.ReadLine()); // Input Number of Element = 3
    int[] arr = new int[arrayElement];

    for(int j = 0; j < arrayElement;j++){
        Console.Write("Array element no :" + j);
        arr[j] = int.Parse(Console.ReadLine());           // Element of an array 1,3,4
    }

    for(int j = 0; j < arrayElement;j++){
        Console.WriteLine("Array element "+ j +" value :" + arr[j]);         // Element of an array 1,3,4
    }    
}
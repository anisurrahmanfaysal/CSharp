var input = Console.ReadLine();

if (input == "vertebrado")
{
    var input1 = Console.ReadLine();
    if (input1 == "ave")
    {
        var input2 = Console.ReadLine();
        if(input2 == "carnivoro")
            Console.WriteLine("aguia");
        else if(input2 == "onivoro")
            Console.WriteLine("pomba");

    }
    else if (input1 == "mamifero")
    {
        var input2 = Console.ReadLine();
        if (input2 == "onivoro")
            Console.WriteLine("homem");
        else if (input2 == "herbivoro")
            Console.WriteLine("vaca");
    }

}
else if (input == "invertebrado")
{
    var input1 = Console.ReadLine();
    if (input1 == "inseto")
    {
        var input2 = Console.ReadLine();
        if (input2 == "hematofago")
            Console.WriteLine("pulga");
        else if (input2 == "herbivoro")
            Console.WriteLine("lagarta");

    }
    else if (input1 == "anelideo")
    {
        var input2 = Console.ReadLine();
        if (input2 == "hematofago")
            Console.WriteLine("sanguessuga");
        else if (input2 == "onivoro")
            Console.WriteLine("minhoca");
    }
}
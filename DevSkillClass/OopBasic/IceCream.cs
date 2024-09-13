using System;

namespace OopBasic;

public class IceCream
{
    int Suger { get; set; }
    public IceCream(int suger){
        Suger = suger;
    }

    public void MakeIcecream(int lemon){
        Console.WriteLine("Lemon Ice-Cream.");
    }

    public void MakeIcecream(int milk, int chocolet, int vanila){
        Console.WriteLine("Chocolet with Vanila Ice-Cream.");
    }
}

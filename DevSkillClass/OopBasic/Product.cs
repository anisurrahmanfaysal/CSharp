
using System;

namespace OopBasic;

public class Product
{
    public double Price { get; set; }

    public double DefaultDiscount { get; set; } = 10;

    public string Name { get; set; }

    public Product() : this(string.Empty)
    {

    }
    public Product(string name) : this(0, string.Empty,10)
    {
        Name = name;
    }
    public Product(double price, string name, double defaultDiscount){
        Price = price;
        Name = name;
        DefaultDiscount = defaultDiscount;
    }

    /// <summary>
    /// Discount Given without a limite.
    /// </summary>
    /// <returns></returns>
    public double CalculateDiscount(){
        return Price * DefaultDiscount/100;
    }

    /// <summary>
    /// Calculate Discount using a maximum discount.
    /// </summary>
    /// <param name="MaximumDiscount">Maximum Discount given.</param>
    /// <returns></returns>
    public double CalculateDiscount(int MaximumDiscount){
        double discount = Price * DefaultDiscount/100;
        return discount > MaximumDiscount
            ? MaximumDiscount
            : discount;
    } 
}

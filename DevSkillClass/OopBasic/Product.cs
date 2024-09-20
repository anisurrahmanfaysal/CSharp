
using System;

namespace OopBasic;

public class Product
{
    public double Price { get; set; }

    private const double DEFAULT_DISCOUNT = 10;
    private readonly string barcode;

    public string Name { get; set; }

    public Product() : this(string.Empty)
    {
        barcode = "ABC-123";
    }
    public Product(string name) : this(0, string.Empty)
    {
        Name = name;
    }
    public Product(double price, string name){
        Price = price;
        Name = name;
    }

    /// <summary>
    /// Discount Given without a limite.
    /// </summary>
    /// <returns></returns>
    public double CalculateDiscount(){
        return Price * DEFAULT_DISCOUNT/100;
    }

    /// <summary>
    /// Calculate Discount using a maximum discount.
    /// </summary>
    /// <param name="MaximumDiscount">Maximum Discount given.</param>
    /// <returns></returns>
    public double CalculateDiscount(int MaximumDiscount){
        double discount = Price * DEFAULT_DISCOUNT/100;
        return discount > MaximumDiscount
            ? MaximumDiscount
            : discount;
    } 
}

using System;

namespace OopBasic;

public class WaterBottle
{
    double capacity;
    string color;
    double waterAmount;

    public double Capacity {
        get {
            return capacity; 
            }
    }

    public string Color {
        get {
            return color;
            }
    }
    public double WaterAmount
    {
        get {
            return waterAmount; 
        }
        private set {
            if(value <= capacity)
                waterAmount = value; 
            }
    }

    public WaterBottle(double capacity, string color){
        this.capacity = capacity;
        this.color = color;
    }

    // ~WaWaterBottle() {
        
    // }

    public void AddWatter(double amount){
        if(amount + waterAmount <= capacity){
            waterAmount = amount + waterAmount;
        }
    }

    public void ReleseWater(double amount){
        if(waterAmount <= amount){
            waterAmount = 0;
        }
        else{
            waterAmount = waterAmount - amount;
        }
    }
}

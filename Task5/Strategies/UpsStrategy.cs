using Task5.Interfaces;
using Task5.Models;

namespace Task5.Strategies;

public class UpsStrategy : IShipmentCalculatorStrategy
{
    public double CalculatePrice(Order order)
        => order.Weight > 400 ? 4.25d * 1.1 : 4.25d;
}
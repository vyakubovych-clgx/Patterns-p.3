using Task5.Interfaces;
using Task5.Models;

namespace Task5.Strategies;

public class FedExStrategy : IShipmentCalculatorStrategy
{
    public double CalculatePrice(Order order)
        => order.Weight > 300 ? 5.00d * 1.1 : 5.00d;
}
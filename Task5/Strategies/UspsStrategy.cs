using Task5.Enums;
using Task5.Interfaces;
using Task5.Models;

namespace Task5.Strategies;

public class UspsStrategy : IShipmentCalculatorStrategy
{
    public double CalculatePrice(Order order)
        => order.Product == ProductType.Book ? 3.00d * 0.9 : 3.00d;
}
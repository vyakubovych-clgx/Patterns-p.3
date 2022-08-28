using Task5.Models;

namespace Task5.Interfaces;

public interface IShipmentCalculatorStrategy
{
    double CalculatePrice(Order order);
}
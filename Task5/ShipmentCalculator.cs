using Task5.Enums;
using Task5.Interfaces;
using Task5.Models;
using Task5.Strategies;

namespace Task5;

public class ShipmentCalculator
{
    public double CalculatePrice(Order order)
    {
        IShipmentCalculatorStrategy strategy = order.ShipmentOptions switch
        {
            ShipmentOptions.FedEx => new FedExStrategy(),
            ShipmentOptions.UPS => new UpsStrategy(),
            ShipmentOptions.USPS => new UspsStrategy(),
            _ => throw new NotImplementedException()
        };

        return strategy.CalculatePrice(order);
    }
}
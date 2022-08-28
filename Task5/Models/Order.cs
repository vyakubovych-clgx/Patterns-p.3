using Task5.Enums;

namespace Task5.Models;

public class Order
{
    public Order(ShipmentOptions shipmentOptions, double weight, ProductType product)
    {
        ShipmentOptions = shipmentOptions;
        Product = product;
        Weight = weight;
    }

    public ShipmentOptions ShipmentOptions { get; }
    public ProductType Product { get; }
    public double Weight { get; }
}
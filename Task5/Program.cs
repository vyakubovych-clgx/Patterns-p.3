using Task5;
using Task5.Enums;
using Task5.Models;

var upsOrder = new Order(ShipmentOptions.UPS, 500, ProductType.Electronic);
var fedExOrder = new Order(ShipmentOptions.FedEx, 400, ProductType.Electronic);
var uspsOrder = new Order(ShipmentOptions.USPS, 300, ProductType.Book);

var calculator = new ShipmentCalculator();
OutputPrice(upsOrder);
OutputPrice(fedExOrder);
OutputPrice(uspsOrder);
Console.ReadLine();

void OutputPrice(Order order)
{
    Console.WriteLine($"{calculator.CalculatePrice(order):0.00}");
}
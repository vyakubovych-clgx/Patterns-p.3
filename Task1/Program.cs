using Task1.Implementations;

var currencyService = new CurrencyService();
var tripRepository = new TripRepository();
var calculatorFactory = new CalculatorFactory(currencyService, tripRepository);
var calculator = calculatorFactory.CreateCalculator();
Console.WriteLine(await calculator.CalculatePayment("Viktor Yakubovych"));
Console.ReadLine();
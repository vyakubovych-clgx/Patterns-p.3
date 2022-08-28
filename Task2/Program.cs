using Task2.Implementations;

var currencyService = new CurrencyService();
var tripRepository = new TripRepository();
var calculatorFactory = new CalculatorFactory(currencyService, tripRepository);
var calculator = calculatorFactory.CreateCachedCalculator();
Console.WriteLine(await calculator.CalculatePayment("Viktor Yakubovych"));
Console.WriteLine();
Console.WriteLine(await calculator.CalculatePayment("Viktor Yakubovych"));
Console.ReadLine();
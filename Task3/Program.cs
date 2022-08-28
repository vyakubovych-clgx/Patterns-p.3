using Task3.Implementations;

var currencyService = new CurrencyService();
var tripRepository = new TripRepository();
var calculatorFactory = new CalculatorFactory(currencyService, tripRepository);

var loggingCalculator = calculatorFactory.CreateLoggingCalculator();
Console.WriteLine(await loggingCalculator.CalculatePayment("Viktor Yakubovych"));
Console.WriteLine();

var roundingCalculator = calculatorFactory.CreateRoundingCalculator();
Console.WriteLine(await roundingCalculator.CalculatePayment("Viktor Yakubovych"));

Console.ReadLine();
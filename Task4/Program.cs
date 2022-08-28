using Task4.Decorators;
using Task4.Implementations;

var currencyService = new CurrencyService();
var tripRepository = new TripRepository();
var calculatorFactory = new CalculatorFactory(currencyService, tripRepository);
var cachedCalculator = calculatorFactory.CreateCachedCalculator();

var cachedLoggingCalculator = calculatorFactory.AssignResponsibility<LoggingCalculator>(cachedCalculator, new Logger());
Console.WriteLine(await cachedLoggingCalculator.CalculatePayment("Viktor Yakubovych"));
Console.WriteLine();
Console.WriteLine(await cachedLoggingCalculator.CalculatePayment("Viktor Yakubovych"));
Console.WriteLine();

var roundingCachedCalculator = calculatorFactory.AssignResponsibility<RoundingCalculator>(cachedCalculator);
Console.WriteLine(await roundingCachedCalculator.CalculatePayment("Viktor Yakubovych"));

Console.ReadLine();
using Task4.Interfaces;

namespace Task4.Implementations;

public class InsurancePaymentCalculator : ICalculator
{
    private readonly ICurrencyService _currencyService;
    private readonly ITripRepository _tripRepository;

    public InsurancePaymentCalculator(ICurrencyService currencyService, ITripRepository tripRepository)
    {
        _currencyService = currencyService;
        _tripRepository = tripRepository;
    }

    public virtual async Task<decimal> CalculatePayment(string touristName)
    {
        var tripDetails = _tripRepository.LoadTrip(touristName);
        var rate = await _currencyService.LoadCurrencyRate();
        return Constants.A * rate * tripDetails.FlyCost
               + Constants.B * rate * tripDetails.AccommodationCost
               + Constants.C * rate * tripDetails.ExcursionCost;
    }
}
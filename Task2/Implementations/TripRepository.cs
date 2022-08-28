using Task2.Interfaces;

namespace Task2.Implementations;

public class TripRepository : ITripRepository
{
    private readonly List<TripDetails> _trips = new()
    {
        new TripDetails
        {
            TouristName = "Viktor Yakubovych",
            FlyCost = 100m,
            AccommodationCost = 300m,
            ExcursionCost = 50m
        }
    };

    public TripDetails LoadTrip(string touristName)
        => _trips.FirstOrDefault(t => t.TouristName == touristName);
}
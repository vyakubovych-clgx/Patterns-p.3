namespace Task4.Interfaces;

public interface ITripRepository
{
    TripDetails LoadTrip(string touristName);
}
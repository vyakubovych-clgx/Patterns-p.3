namespace Task2.Interfaces;

public interface ITripRepository
{
    TripDetails LoadTrip(string touristName);
}
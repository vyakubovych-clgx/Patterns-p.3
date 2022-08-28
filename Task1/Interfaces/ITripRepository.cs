namespace Task1.Interfaces;

public interface ITripRepository
{
    TripDetails LoadTrip(string touristName);
}
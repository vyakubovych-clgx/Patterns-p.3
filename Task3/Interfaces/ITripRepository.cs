namespace Task3.Interfaces;

public interface ITripRepository
{
    TripDetails LoadTrip(string touristName);
}
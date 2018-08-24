using FlightReservation.Dal.Repository.Base;

namespace FlightReservation.Dal.Repository
{
    public interface IPassengerRepository : IGenericRepository<Passenger>
    {
        Passenger GetSingle(int PasengerId);
    }

}
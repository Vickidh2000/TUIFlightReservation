using FlightReservation.Dal.Repository.Base;

namespace FlightReservation.Dal.Repository
{
    public interface IFlightRepository : IGenericRepository<Flight>
    {
        Flight GetSingle(int fooId);
    }
}
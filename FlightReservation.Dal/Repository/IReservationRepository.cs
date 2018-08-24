using FlightReservation.Dal.Repository.Base;
using System.Collections.Generic;
using System.Linq;

namespace FlightReservation.Dal.Repository
{
    public interface IReservationRepository : IGenericRepository<Reservation>
    {
        Reservation GetSingle(int id);

        new IQueryable<Reservation> GetAll();
    }
      
   
}
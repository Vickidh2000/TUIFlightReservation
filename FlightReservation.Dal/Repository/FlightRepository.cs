using FlightReservation.Dal.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Dal.Repository
{
    public class FlightRepository : GenericRepository<FlightReservationEntities, Flight>, IFlightRepository
    {

        public Flight GetSingle(int flightId)
        {
            var query = GetAll().FirstOrDefault(x => x.Flight_Id == flightId);
            return query;
        }
    }
}

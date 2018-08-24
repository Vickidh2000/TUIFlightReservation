using FlightReservation.Dal.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Dal.Repository
{
    public class PassegerRepository : GenericRepository<FlightReservationEntities, Passenger>, IPassengerRepository
    {

        public Passenger GetSingle(int PassegerId)
        {

            var query = Context.Passengers.FirstOrDefault(x => x.Passenger_id == PassegerId);
            return query;
        }
    }
}

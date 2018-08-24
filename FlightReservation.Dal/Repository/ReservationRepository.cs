using FlightReservation.Dal.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Dal.Repository
{
    public class ReservationRepository : GenericRepository<FlightReservationEntities, Reservation>, IReservationRepository
    {
        public void Add(Reservation entity)
        {
       
        }

        public void Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Reservation> FindBy(Expression<Func<Reservation, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Reservation>.Add(Reservation entity)
        {
                Add(entity);
                Save();
        }

        void IGenericRepository<Reservation>.Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Reservation>.Edit(Reservation entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Reservation> IGenericRepository<Reservation>.FindBy(Expression<Func<Reservation, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        IQueryable<Reservation> IGenericRepository<Reservation>.GetAll()
        {
            var query = GetAll();
            return query;
        }

        //List<Reservation> IReservationRepository.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        Reservation IReservationRepository.GetSingle(int id)
        {
            var query = GetAll().FirstOrDefault(x => x.Reservation_id == id);
            return query;
        }

        void IGenericRepository<Reservation>.Save()
        {
            throw new NotImplementedException();
        }
    }
}



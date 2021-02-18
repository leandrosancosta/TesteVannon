using Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL
{
    public class RentDAL : DefaultContext
    {
        public IQueryable<Rent> GetRentsList()
        {
            return _context.Rents;
        }

        public Rent Add(Rent model)
        {
            _context.Rents.Add(model);
            _context.SaveChanges();

            return model;
        }

        public Rent GetRentById(int? id)
        {
            if (id == 0 || id == null)
                return null;

            return _context.Rents.Where(m => m.ID == id).FirstOrDefault();
        }

        public Rent UpdateRent(Rent model)
        {
            _context.Entry(model).State = EntityState.Modified;
            return model;
        }
    }
}

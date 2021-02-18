using Core.Model;
using Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
{
    public class RentsBusiness
    {
        public RentDAL dal;

        public RentsBusiness()
        {
            dal = new RentDAL();
        }

        public IQueryable<Rent> GetRents()
        {
            return dal.GetRentsList();
        }

        public Rent AddRent(Rent model)
        {
            return dal.Add(model);
        }

        public Rent Edit(Rent model)
        {
            return dal.UpdateRent(model);
        }

        public Rent GetRentById(int? id)
        {
            if (id == 0 || id == null)
                return null;

            return dal.GetRentById(id);

        }
    }
}

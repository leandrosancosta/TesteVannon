using Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL
{
    public class CustomerDAL : DefaultContext
    {
        public IQueryable<Customer> GetCustomersList()
        {
            return _context.Customers;
        }

        public Customer Add(Customer model)
        {
            _context.Customers.Add(model);
            _context.SaveChanges();

            return model;
        }

        public Customer GetCustomerById(int? id)
        {
            if (id == 0 || id == null)
                return null;

            return _context.Customers.Where(m => m.ID == id).FirstOrDefault();
        }

        public Customer UpdateCustomer(Customer model)
        {
            _context.Entry(model).State = EntityState.Modified;
            return model;
        }
    }
}

using Core.Model;
using Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
{
    public class CustomersBusiness
    {
        public CustomerDAL dal;

        public CustomersBusiness()
        {
            dal = new CustomerDAL();
        }

        public IQueryable<Customer> GetCustomers()
        {
            return dal.GetCustomersList();
        }

        public Customer AddCustomers(Customer model)
        {
            return dal.Add(model);
        }

        public Customer Edit(Customer model)
        {
            return dal.UpdateCustomer(model);
        }

        public Customer GetCustomersById(int? id)
        {
            if (id == 0 || id == null)
                return null;

            return dal.GetCustomerById(id);

        }
    }
}

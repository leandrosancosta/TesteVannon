using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL
{
    public class DefaultContext
    {
        protected DataContext _context;

        protected DefaultContext()
        {
            _context = new DataContext();
        }
    }
}

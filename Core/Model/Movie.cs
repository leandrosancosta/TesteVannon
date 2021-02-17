using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Movie
    {
        public int ID { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        public int ParentalGuide { get; set; }
        [MaxLength(240)]
        public string Resume { get; set; }
        public DateTime Released { get; set; }
        public string Gender { get; set; }
        public int Stats { get; set; }
        public int Quantity { get; set; }
    }
}

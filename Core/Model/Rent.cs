using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    public class Rent
    {
        public int ID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime Return { get; set; }
        public int Stats { get; set; }
        public Guid UserId { get; set; }

        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
    }
}

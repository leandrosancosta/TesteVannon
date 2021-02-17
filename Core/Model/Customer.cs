using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Customer
    {
        public int ID { get; set; }
        [MaxLength(11)]
        public string CPF { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(11)]
        public string TelNumber { get; set; }
        [MaxLength(80)]
        public string Email { get; set; }
        public int Stats { get; set; }
    }
}

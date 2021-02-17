using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Service.Areas.App.Models
{
    public class MovieViewModel
    {
        public int ID { get; set; }
        [Display(Name="Título")]
        public string Name { get; set; }
        [Display(Name = "Classificação")]
        public int ParentalGuide { get; set; }
        [Display(Name = "Sinopse")]
        public string Resume { get; set; }
        [Display(Name = "Lançamento")]
        public DateTime Released { get; set; }
        [Display(Name = "Genêro")]
        public string Gender { get; set; }
        [Display(Name = "Status")]
        public int Stats { get; set; }
        [Display(Name = "Quantidade Disponível")]
        public int Quantity { get; set; }
    }
}
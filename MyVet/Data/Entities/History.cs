using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Data.Entities
{
    public class History 
    {
        public int Id { get; set; }

        public ServiceType ServiceType { get; set; }

        
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "Fecha*")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public Pet Pet { get; set; }

        [Display(Name = "Hora Local*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();


    }
}

using System.ComponentModel.DataAnnotations;

namespace MyVet.Data.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Display(Name = "Servicio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Display(Name = "No Identidad")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Telefono Fijo")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        public string FixedPhone { get; set; }

        [Display(Name = "Celular")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        public string CellPhone { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }


}


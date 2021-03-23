using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Models
{
    public class AddUserViewModel
    {
        [Display(Name = "Email")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress]
        public string Username { get; set; }

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

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        public string Address { get; set; }

        [Display(Name = "Telefono")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de  {1} caracteres.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres.")]
        public string Password { get; set; }

        [Display(Name = "Password Confirm")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}



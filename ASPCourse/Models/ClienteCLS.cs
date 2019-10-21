using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPCourse.Models
{
    public class ClienteCLS
    {
        [Display(Name ="Id Cliente")]
        public int iidcliente { get; set; }
        [Required]
        [Display(Name = "Nombre Cliente")]
        [StringLength(100, ErrorMessage = "La longitud maxima es 100")]
        public string nombre { get; set; }
        [Required]
        [Display(Name = "Apellido Paterno")]
        [StringLength(150, ErrorMessage = "La longitud maxima es 150")]
        public string appaterno { get; set; }
        [Required]
        [Display(Name = "Apellido Materno")]
        [StringLength(150, ErrorMessage = "La longitud maxima es 150")]
        public string apmaterno { get; set; }
        [Required]
        [Display(Name = "Email")]
        [StringLength(200, ErrorMessage = "La longitud maxima es 200")]
        [EmailAddress(ErrorMessage ="Ingrese un Email valido")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        [StringLength(200, ErrorMessage = "La longitud maxima es 200")]
        public string direccion { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public int iidsexo { get; set; }
        [Display(Name = "Telefono Fijo")]
        [StringLength(10, ErrorMessage = "La longitud maxima es 10")]
        [Required]
        public string telefonofijo { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "La longitud maxima es 10")]
        [Display(Name = "Telefono Celular")]
        public string telefonocelular { get; set; }
        public int bhabilitado { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPCourse.Models
{
    public class SucursalCLS
    {
        [Display(Name = "Id Sucursal")]
        public int iidsucursal { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "La longitud maxima es 100")]
        [Display(Name = "Nombre de Sucursal")]
        public string nombre { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        [StringLength(200, ErrorMessage = "La longitud maxima es 200")]
        public string direccion { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "La longitud maxima es 10")]
        [Display(Name = "Telefono de Sucursal")]
        public string telefono { get; set; }
        [StringLength(100, ErrorMessage = "La longitud maxima es 100")]
        [Required]
        [Display(Name = "Email de Sucursal")]
        [EmailAddress(ErrorMessage ="Ingresar Email valido")]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [Display(Name = "Fecha de Apertura")]
        public DateTime fechaApertura { get; set; }
        public int bhabilitado { get; set; }


    }
}
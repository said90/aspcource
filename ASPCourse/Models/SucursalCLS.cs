using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPCourse.Models
{
    public class SucursalCLS
    {
        [Display(Name ="Id Sucursal")]
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
        public string email { get; set; }
        [Required]
        [Display(Name = "Fecha de Apertura")]
        [DataType(DataType.Date)]
        public DateTime fechaApertura { get; set; }
        public int bhabilitado { get; set; }


    }
}
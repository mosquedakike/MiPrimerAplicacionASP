using System;
using System.ComponentModel.DataAnnotations;

namespace MiPrimerAplicacionASP.Models
{
    public class SucursalCLS
    {
        [Display(Name = "Id Sucursal")]
        public int iidsucursal { get; set; }
        [Display(Name = "Nombre Sucursal")]
        public string nombre { get; set; }
        [Display(Name = "Direccion")]
        public string direccion { get; set; }
        [Display(Name = "Telefono Sucursal")]
        public string telefono { get; set; }
        [Display(Name = "Email Sucursal")]
        public string email { get; set; }
        public DateTime fechaapertura { get; set; }
        public int bhabilitado { get; set; }
    }
}
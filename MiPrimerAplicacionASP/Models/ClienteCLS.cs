using System.ComponentModel.DataAnnotations;

namespace MiPrimerAplicacionASP.Models
{
    public class ClienteCLS
    {
        [Display(Name = "Id Cliente")]
        public int iidcliente { get; set; }
        [Display(Name = "Nombre Cliente")]
        public string nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string appaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        public string apmaterno { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public int iidsexo { get; set; }
        [Display(Name = "Telelfono Fijo")]
        public string telefono { get; set; }
        public string telefonocelular { get; set; }
        public int bhabilitado { get; set; }
        public int btieneusuario { get; set; }
        public string tipousuario { get; set; }
    }
}
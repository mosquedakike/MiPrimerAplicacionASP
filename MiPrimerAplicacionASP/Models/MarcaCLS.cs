﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimerAplicacionASP.Models
{
    public class MarcaCLS
    {
        [Display(Name = "ID Marca")]
        public int iidmarca { get; set; }
        [Display(Name = "Nombre Marca")]
        [Required]
        [StringLength(100, ErrorMessage = "La longitud maxima es de 100")]
        public string nombre { get; set; }
        [Display(Name = "Descripcion Marca")]
        [Required]
        [StringLength(200, ErrorMessage = "La longitud maxima es de 200")]
        public string descripcion { get; set; }
        public int bhabilitado { get; set; }
    }
}
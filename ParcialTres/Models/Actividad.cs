using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialTres.Models
{
    public class Actividad 
    {
        [Key]
        public int ActividadId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "(0) es requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Debe de tener entre 2 y 50 carasteres")]
        public string TipoActividad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "(0) es requerido")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Debe de tener entre 2 y 200 carasteres")]
        public string Accion { get; set; }
        [Url]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Debe de tener entre 10 y 100 carasteres")]
        public string Enlace { get; set; }
    }
}

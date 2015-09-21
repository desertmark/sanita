using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sanita.Models
{
    public class Banner
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Display(Name="Imagenes")]
        public string Img { get; set; }
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
    }
}
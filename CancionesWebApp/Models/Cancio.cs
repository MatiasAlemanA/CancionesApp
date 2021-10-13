using System.ComponentModel.DataAnnotations;

namespace CancionesWebApp.Models
{
    public class Cancio
    {
        [Key]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Es requerido")]
        [Display(Name = "Nombre de la cancion")]
        public string Autor { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage ="Es requerido")]
        [Display(Name = "Auto de la cancion")]
        public string Letra { get; set; }
        [Url]
        [StringLength(1000)]
        public string Enlace { get; set; }

    }
}

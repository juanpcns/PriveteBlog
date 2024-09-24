using System.ComponentModel.DataAnnotations;

namespace PrivateBlog.Web.Data.Entities
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Sección")]
        [Required(ErrorMessage = "El campo '{0}' es requerido.")]
        public String Name { get; set; }
        [Display(Name = "Sección")]
        public String Description { get; set; }

        [Display(Name="¿Está oculta?")]
        public bool IsHidden { get; set; }
    }
}

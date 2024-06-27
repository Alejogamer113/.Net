using System.ComponentModel.DataAnnotations;

namespace aplicacionweb.Models
{
    public class TipoOferta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NombreOferta { get; set; }

        public ICollection<Oferta>? Oferta { get; set; }
    }
}

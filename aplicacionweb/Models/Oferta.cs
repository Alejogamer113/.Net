using System.ComponentModel.DataAnnotations;

namespace aplicacionweb.Models
{
    public class Oferta
    {
        [Key]
       public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        public int Precio { get; set; }
        public int TipoOfertaId { get; set; }
        public TipoOferta? TipoOferta { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ProEventos.Domain
{
    public class Evento
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int Quantidade { get; set; }
        public string Image { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Lote>? Lote { get; set; }
        public IEnumerable<RedeSocial>? RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento>? PalestrantesEventos { get; set; }
    }
}

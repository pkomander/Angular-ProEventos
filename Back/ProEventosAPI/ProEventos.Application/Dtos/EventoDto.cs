using ProEventos.Domain;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        [Required(ErrorMessage = "O campo {0} e obrigatorio.")]
        [MinLength(3, ErrorMessage = "{0} deve ter no minimo 4 caracteres.")]
        [MaxLength(50, ErrorMessage = "{0} deve ter no minimo 50 caracteres.")]
        public string Tema { get; set; }
        [Display(Name = "Qtd Pessoas")]
        [Range(1, 120000, ErrorMessage = "{0} nao pode ser menor que 1 e maior que 120.000")]
        public int Quantidade { get; set; }
        //aplicando Regex para verificar se o arquivo e do tipo img
        [RegularExpression(@".*\.(gif|jpeg?g|bmp|png)$", ErrorMessage = "Nao e uma imagem valida. (gif, png, jpg, bmp, jpeg)")]
        public string Image { get; set; }
        [Required(ErrorMessage = "O campo {0} e obrigatorio.")]
        [Phone(ErrorMessage = "O campo {0} esta com o numero invalido.")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "O campo {0} e obrigatorio.")]
        [Display(Name = "e-mail")]
        [EmailAddress(ErrorMessage = "O campo {0} precisa ser um email valido.")]
        public string Email { get; set; }
        public IEnumerable<LoteDto>? Lote { get; set; }
        public IEnumerable<RedeSocialDto>? RedesSociais { get; set; }
        public IEnumerable<PalestranteDto>? PalestrantesEventos { get; set; }
    }
}

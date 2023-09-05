using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackClientes.RazorPages.Models {
    public class FeedbackModel {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? IdFeedback { get; set; }
        [Required(ErrorMessage ="Nome do Cliente é obrigatório")]
        public string? NomeCliente { get; set; }
        public string? EmailCliente { get; set; }
        [Required(ErrorMessage ="Data é obrigatória")]
        [DisplayFormat(DataFormatString ="{0:dd MMM yyyy}")]
        public DateTime? DataFeedback { get; set; }
        [Required(ErrorMessage ="Comentário é obrigatório")]
        public string? Comentário { get; set; }
        [Range(1, 5, 
            ErrorMessage = "Avaliação deve estar em uma escala de 1 a 5, onde 1 é \"Muito insatisfeito\" e 5 é \"Muito satisfeito\"")]
        public int? Avaliação { get; set; }
    }
}
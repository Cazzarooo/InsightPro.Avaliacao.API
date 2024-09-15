using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsightPro.Avaliacao.Domain.Entities
{
    [Table("tb_avaliacao")]
    public class AvaliacaoEntity
    {
        [Key]
        public int Id { get; set; }
        public string Comentario { get; set; } = string.Empty;
        public int Nota { get; set; }
    }
}

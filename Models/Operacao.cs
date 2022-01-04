using System.ComponentModel.DataAnnotations;

namespace TestInvestmentCart.Models
{
    public class Operacao
    {
        [Key]
        public int Id { get; set; }
        public int AcaoId { get; set; }
        public DateTime DtOperacao { get; set; }
        public char StOperacao { get; set; }
        public int QtdOperacao { get; set; }
        public double VlAcao { get; set; }
        public double VlOperacao { get; set; }
    }
}
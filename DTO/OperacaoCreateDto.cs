using System.ComponentModel.DataAnnotations;

namespace TestInvestmentCart.Models
{
    public class OperacaoCreateDto
    {
        public int AcaoId { get; set; }
        public DateTime DtOperacao { get; set; }
        public char StOperacao { get; set; }
        public int QtdOperacao { get; set; }
    }
}
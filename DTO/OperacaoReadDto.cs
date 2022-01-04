namespace TestInvestmentCart.DTO
{
    public class OperacaoReadDto
    {
        public string Acao { get; set; }
        public string RazaoSocial { get; set; }
        public DateTime DtOperacao { get; set; }
        public string TipoOperacao { get; set; }
        public int QtdOperacao { get; set; }
        public double VlAcao { get; set; }
        public double VlOperacao { get; set; }
    }
}
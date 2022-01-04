namespace TestInvestmentCart.DTO
{
    public class OperacaoReadDto
    {
        public int Id { get; set; }
        public string Acao { get; set; }
        public DateTime DtOperacao { get; set; }
        public char StOperacao { get; set; }
        public int QtdOperacao { get; set; }
        public double VlAcao { get; set; }
        public double VlOperacao { get; set; }
    }
}
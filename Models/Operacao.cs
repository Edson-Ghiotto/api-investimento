namespace TestInvestmentCart.Models
{
    public class Operacao
    {
        public int Id { get; set; }
        public Acao Acao { get; set; }
        public DateTime DtOperacao { get; set; }
        public char StOperacao { get; set; }
        public int QtdOperacao { get; set; }
        public double VlAcao { get; set; }
        public double VlOperacao { get; set; }

        public Operacao(){
            Id = 0;
            Acao = new Acao();
            DtOperacao = DateTime.Now;
            StOperacao = 'V';
            QtdOperacao = 0;
            VlAcao = 0;
            VlOperacao = 0;
        }
    }
}
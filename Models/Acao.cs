namespace TestInvestmentCart.Models
{

    public class Acao
    {
        public int Id {get;set;}
        public string Codigo {get;set;}
        public string RazaoSocial {get;set;}

        public Acao(){
            Id = 0;
            Codigo = "";
            RazaoSocial = "";
        }
    }
}
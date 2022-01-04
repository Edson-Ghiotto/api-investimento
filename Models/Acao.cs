using System.ComponentModel.DataAnnotations;

namespace TestInvestmentCart.Models
{

    public class Acao
    {
        [Key]
        public int Id {get;set;}
        public string Codigo {get;set;}
        public string RazaoSocial {get;set;}

        public Acao(){
            Codigo = "";
            RazaoSocial = "";
        }
    }
}
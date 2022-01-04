using System.Collections.Generic;
using TestInvestmentCart.Data.Interface;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Data.Mock
{
    public class MockAcaoRepository : IAcaoRepository
    {
        public Acao GetAcaoById (int id)
        {
            return new Acao{Id=id,Codigo="NONE",RazaoSocial="Nome"};
        }

        public Acao GetAcaoByCodigo(string codigo){
            return new Acao{Id=0,Codigo=codigo,RazaoSocial="Nome"};
        }

        public void AddAcao(string codigo, string razaoSocial)
        {
            throw new NotImplementedException();
        }
    }
}
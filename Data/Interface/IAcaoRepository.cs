using System.Collections.Generic;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Data.Interface
{
    public interface IAcaoRepository
    {
        Acao GetAcaoById(int id);
        
        Acao GetAcaoByCodigo(string codigo);

        void AddAcao(string codigo, string razaoSocial);
        
    }
}
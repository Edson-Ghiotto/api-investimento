using System.Collections.Generic;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Data.Interface
{
    public interface IAcaoRepository
    {
        bool SaveChanges();
        Acao GetAcaoById(int id);
        
        Acao GetAcaoByCodigo(string codigo);

        void AddAcao(Acao acao);
        
    }
}
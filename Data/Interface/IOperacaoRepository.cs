using System.Collections.Generic;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Data.Interface
{
    public interface IOperacaoRepository
    {
        bool SaveChanges();
        Operacao GetOperacaoById(int id);
        
        IEnumerable<Operacao> ListOperacoes();

        void AddOperacao(Operacao operacao);
        
    }
}
using System.Collections.Generic;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Data.Interface
{
    public interface IOperacaoRepository
    {
        Operacao GetOperOperacaoById(int id);
        
        IEnumerable<Operacao> ListOperacoes();

        void AddOperacao(Operacao operacao);
        
    }
}
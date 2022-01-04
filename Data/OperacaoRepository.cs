using TestInvestmentCart.Data.Interface;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Data
{
    public class OperacaoRepository : IOperacaoRepository
    {
        InvestmentContext _context;
        public OperacaoRepository(InvestmentContext context)
        {
            _context = context;   
        }
        public void AddOperacao(Operacao operacao)
        {
            if(operacao == null){
                throw new ArgumentNullException(nameof(operacao));
            }
            
            _context.Operacoes.Add(operacao);
            
        }

        public Operacao GetOperacaoById(int id)
        {
            return _context.Operacoes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Operacao> ListOperacoes()
        {
            return _context.Operacoes.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
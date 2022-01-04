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
            _context.Database.EnsureCreatedAsync();
            _context.Operacoes.Add(operacao);
            _context.SaveChangesAsync();
        }

        public Operacao GetOperOperacaoById(int id)
        {
            return _context.Operacoes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Operacao> ListOperacoes()
        {
            return _context.Operacoes.ToList();
        }
    }
}
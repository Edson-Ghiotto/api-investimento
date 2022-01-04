using System.Collections.Generic;
using TestInvestmentCart.Data.Interface;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Data
{
    public class AcaoRepository : IAcaoRepository
    {
        InvestmentContext _context;
        public AcaoRepository(InvestmentContext context)
        {
            _context = context;
        }

        public Acao GetAcaoById (int id)
        {
            return _context.Acoes.FirstOrDefault(x => x.Id == id);
        }

        public Acao GetAcaoByCodigo(string codigo){
            return _context.Acoes.FirstOrDefault(x => x.Codigo == codigo);
        }

        public void AddAcao(string codigo, string razaoSocial)
        {
            _context.Database.EnsureCreatedAsync();
            _context.Acoes.Add(new (){Codigo = codigo, RazaoSocial = razaoSocial});
            _context.SaveChangesAsync();
        }
    }
}
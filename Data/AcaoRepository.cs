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

        public void AddAcao(Acao acao)
        {
            if(acao == null){
                throw new ArgumentNullException(nameof(acao));
            }

            _context.Acoes.Add(acao);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
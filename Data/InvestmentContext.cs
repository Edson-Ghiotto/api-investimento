using Microsoft.EntityFrameworkCore;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Data
{
    public class InvestmentContext : DbContext
    {
        public InvestmentContext(DbContextOptions<InvestmentContext> opt) : base(opt)
        {
            
        }

        public DbSet<Acao> Acoes { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }
    }
}
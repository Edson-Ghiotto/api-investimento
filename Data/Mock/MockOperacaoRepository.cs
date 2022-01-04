using TestInvestmentCart.Data.Interface;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Data.Mock
{
    public class MockOperacaoRepository : IOperacaoRepository
    {
        public void AddOperacao(Operacao operacao)
        {
            throw new NotImplementedException();
        }

        public Operacao GetOperacaoById(int id)
        {
            return new Operacao{Id=id,AcaoId=0,DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='V',VlAcao=10,VlOperacao=15.325};
        }

        public IEnumerable<Operacao> ListOperacoes()
        {
            var operacoes = new List<Operacao>
            {
                new Operacao{Id=1,AcaoId=0,DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='V',VlAcao=10,VlOperacao=15.325},
                new Operacao{Id=2,AcaoId=0,DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='C',VlAcao=10,VlOperacao=15.325},
                new Operacao{Id=3,AcaoId=0,DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='C',VlAcao=10,VlOperacao=15.325},
                new Operacao{Id=4,AcaoId=0,DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='V',VlAcao=10,VlOperacao=15.325}
            };
            return operacoes;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
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

        public Operacao GetOperOperacaoById(int id)
        {
            Acao acao = new Acao{Id=0,Codigo="NONE",RazaoSocial="Nome"};
            return new Operacao{Id=id,Acao=acao,DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='V',VlAcao=10,VlOperacao=15.325};
        }

        public IEnumerable<Operacao> ListOperacoes()
        {
            var operacoes = new List<Operacao>
            {
                new Operacao{Id=1,Acao=new Acao{Id=0,Codigo="NONE",RazaoSocial="Nome"},DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='V',VlAcao=10,VlOperacao=15.325},
                new Operacao{Id=2,Acao=new Acao{Id=0,Codigo="NONE",RazaoSocial="Nome"},DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='C',VlAcao=10,VlOperacao=15.325},
                new Operacao{Id=3,Acao=new Acao{Id=0,Codigo="NONE",RazaoSocial="Nome"},DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='C',VlAcao=10,VlOperacao=15.325},
                new Operacao{Id=4,Acao=new Acao{Id=0,Codigo="NONE",RazaoSocial="Nome"},DtOperacao=DateTime.Now,QtdOperacao=100,StOperacao='V',VlAcao=10,VlOperacao=15.325}
            };
            return operacoes;
        }
    }
}
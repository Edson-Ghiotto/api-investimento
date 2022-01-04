using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestInvestmentCart.Data.Interface;
using TestInvestmentCart.Data.Mock;
using TestInvestmentCart.Models;
using YahooFinanceApi;

namespace TestInvestmentCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacoesController : ControllerBase
    {

        private readonly IOperacaoRepository _repository;
        private readonly IAcaoRepository _acaoRepository;

        public OperacoesController(IOperacaoRepository repository, IAcaoRepository acaoRepository)
        {
            _repository = repository;
            _acaoRepository = acaoRepository;
        }

        [HttpPost("{acao&qtd&tipo}")]
        public void RegistrarOperacao(string codigo, int qtd, char tipo){
            var acao = _acaoRepository.GetAcaoByCodigo(codigo);
            var valorAcao = ObterCotacaoAcao(codigo);
            
            _repository.AddOperacao(new Operacao(){Acao=acao, QtdOperacao=qtd, StOperacao=tipo, VlAcao=valorAcao, VlOperacao = CalcularValorOperacao(valorAcao, qtd)});
        }

        [HttpGet]
        public ActionResult<IEnumerable<Operacao>> ListarOperacoes(){
            var operacoes = _repository.ListOperacoes();
            return Ok(operacoes);
        }

        private double CalcularValorOperacao(double valor, int quantidade){
            var valorOperacao = valor * quantidade;
            var custoOperacao = 5 + (valorOperacao * 0.0325);
            
            return valorOperacao + custoOperacao;
        }

        private double ObterCotacaoAcao(string codigo){
            var securities = Yahoo.Symbols(codigo).Fields(Field.Symbol, Field.RegularMarketPrice, Field.FiftyTwoWeekHigh).QueryAsync();
            var acao = securities.Result["AAPL"];
            var preco = acao[Field.RegularMarketPrice];
            return preco;
        }
    }
}
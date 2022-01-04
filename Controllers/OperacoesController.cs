using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestInvestmentCart.Data.Interface;
using TestInvestmentCart.Data.Mock;
using TestInvestmentCart.DTO;
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
        private readonly IMapper _mapper;

        public OperacoesController(IOperacaoRepository repository, IAcaoRepository acaoRepository, IMapper mapper)
        {
            _repository = repository;
            _acaoRepository = acaoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult <OperacaoCreateDto> RegistrarOperacao(OperacaoCreateDto operacao){

            ObterCotacaoAcao("AAPL");

            var operacaoModel = _mapper.Map<Operacao>(operacao);
            var acao = _acaoRepository.GetAcaoById(operacao.AcaoId);
            
            var valorAcao = ObterCotacaoAcao(acao.Codigo);

            operacaoModel.VlAcao = valorAcao;
            operacaoModel.VlOperacao = CalcularValorOperacao(valorAcao,operacao.QtdOperacao);

            try{
                _repository.AddOperacao(operacaoModel);
                _repository.SaveChanges();

                return Ok(operacaoModel);
            }
            catch{
                return Ok(operacaoModel);
            }
        }

        //GET api/operacoes
        [HttpGet]
        public ActionResult<IEnumerable<OperacaoReadDto>> ListarOperacoes(){
            var operacoes = _repository.ListOperacoes();
            if(operacoes != null && operacoes.Count() > 0){
                return Ok(_mapper.Map<IEnumerable<OperacaoReadDto>>(operacoes));
            }
            else{
                return NotFound();  
            }
            
        }

        private double CalcularValorOperacao(double valor, int quantidade){
            var valorOperacao = valor * quantidade;
            var custoOperacao = 5 + (valorOperacao * 0.0325);
            
            return valorOperacao + custoOperacao;
        }

        private double ObterCotacaoAcao(string codigo){
            var securities = Yahoo.Symbols(codigo).Fields(Field.Symbol, Field.RegularMarketPrice, Field.FiftyTwoWeekHigh).QueryAsync();
            var acao = securities.Result[codigo];
            var preco = acao[Field.RegularMarketPrice];
            return preco;
        }
    }
}
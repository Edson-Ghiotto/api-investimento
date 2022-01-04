using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestInvestmentCart.Data.Interface;
using TestInvestmentCart.DTO;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Controllers
{
    // api/acoes
    [Route("api/[controller]")]
    [ApiController]
    public class AcoesController : ControllerBase
    {
        private readonly IAcaoRepository _repository;
        private readonly IMapper _mapper;

        public AcoesController(IAcaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //POST 
        [HttpPost]
        public ActionResult <AcaoCreateDto> CadastrarAcao(AcaoCreateDto acao)
        {
            var acaoModel = _mapper.Map<Acao>(acao);

            _repository.AddAcao(acaoModel);
            _repository.SaveChanges();

            return Ok(acaoModel);
            
        }
    }
}
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestInvestmentCart.Data.Interface;

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
        public ActionResult CadastrarAcao(string codigo, string razaoSocial){
            try{
                _repository.AddAcao(codigo, razaoSocial);
                return Ok();
            }
            catch{
                return Forbid();
            }
        }
    }
}
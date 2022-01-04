using AutoMapper;
using TestInvestmentCart.DTO;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Profiles
{
    public class AcoesProfile : Profile
    {
        public AcoesProfile()
        {
            CreateMap<Acao, AcaoReadDto>();
            CreateMap<AcaoCreateDto, Acao>();
        }
    }
}
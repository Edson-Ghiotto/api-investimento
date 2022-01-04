using AutoMapper;
using TestInvestmentCart.DTO;
using TestInvestmentCart.Models;

namespace TestInvestmentCart.Profiles
{
    public class OperacoesProfile : Profile
    {
        public OperacoesProfile()
        {
            CreateMap<Operacao, OperacaoReadDto>();
            CreateMap<OperacaoCreateDto, Operacao>();
        }
    }
}
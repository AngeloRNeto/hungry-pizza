using AutoMapper;
using EnumsNET;
using HungryPizza.Api.Models.OpcaoPizza;
using HungryPizza.Api.Models.Pedido;
using HungryPizza.Api.ViewModels.Pedido;
using HungryPizza.Domain.Entities;

namespace HungryPizza.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pedido, InformacaoPedidoResponseModel>()
                .ForMember(dest => dest.StatusPedido, opt => opt.MapFrom(src => src.StatusPedido.AsString(EnumFormat.Description)))
                .ForMember(dest => dest.Observacao, opt => opt.MapFrom(src => src.Observacao))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.Valor))
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.Codigo));

            CreateMap<Endereco, EnderecoPedidoModel>()
                .ForMember(dest => dest.Rua, opt => opt.MapFrom(src => src.Rua))
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Numero))
                .ForMember(dest => dest.Complemento, opt => opt.MapFrom(src => src.Complemento))
                .ForMember(dest => dest.Bairro, opt => opt.MapFrom(src => src.Bairro));

            CreateMap<EnderecoPedidoModel, Endereco>()
                .ForMember(dest => dest.Rua, opt => opt.MapFrom(src => src.Rua))
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Numero))
                .ForMember(dest => dest.Complemento, opt => opt.MapFrom(src => src.Complemento))
                .ForMember(dest => dest.Bairro, opt => opt.MapFrom(src => src.Bairro));

            CreateMap<RegistrarPedidoRequestModel, Pedido>()
                .ForMember(dest => dest.IdsSabores, opt => opt.MapFrom(src => src.Sabores))
                .ForMember(dest => dest.Observacao, opt => opt.MapFrom(src => src.Observacao))
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco));


            CreateMap<RegistroOpcaoPizzaModel, OpcaoPizza>()
                .ForMember(dest => dest.DescricaoSabor, opt => opt.MapFrom(src => src.DescricaoSabor))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.Valor));

            CreateMap<OpcaoPizza, RegistroOpcaoPizzaModel>()
                .ForMember(dest => dest.DescricaoSabor, opt => opt.MapFrom(src => src.DescricaoSabor))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.Valor));

        }
    }
}

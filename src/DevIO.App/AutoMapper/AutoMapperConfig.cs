using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Business.Models;

namespace DevIO.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        //Classe que mapeias as entidade da camada de dados para entidade viewmodel e vice e versa
        // Para mepar a entidade view model para entidade de  dados é necessário um construtor sem parametros
        public AutoMapperConfig()
        {
            
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
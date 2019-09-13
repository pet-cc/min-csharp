using AutoMapper;
using Entidades;
using minicurso.Models;

namespace minicurso.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cidade, CidadeModel>()
                .ForMember(x => x.CID_ID, map => map.MapFrom(y => y.CID_ID))
                .ForMember(x => x.CID_NOME, map => map.MapFrom(y => y.CID_NOME))
                .ForMember(x => x.CID_UF, map => map.MapFrom(y => y.CID_UF));
            CreateMap<CidadeModel, Cidade>()
                .ForMember(x => x.CID_ID, map => map.MapFrom(y => y.CID_ID))
                .ForMember(x => x.CID_NOME, map => map.MapFrom(y => y.CID_NOME))
                .ForMember(x => x.CID_UF, map => map.MapFrom(y => y.CID_UF));

            CreateMap<Categoria, CategoriaModel>()
                .ForMember(x => x.CAT_ID, map => map.MapFrom(y => y.CAT_ID))
                .ForMember(x => x.CAT_NOME, map => map.MapFrom(y => y.CAT_NOME));
            CreateMap<CategoriaModel, Categoria>()
                .ForMember(x => x.CAT_ID, map => map.MapFrom(y => y.CAT_ID))
                .ForMember(x => x.CAT_NOME, map => map.MapFrom(y => y.CAT_NOME));

            CreateMap<Autor, AutorModel>()
                .ForMember(x => x.AUT_ID, map => map.MapFrom(y => y.AUT_ID))
                .ForMember(x => x.AUT_IDADE, map => map.MapFrom(y => y.AUT_IDADE))
                .ForMember(x => x.AUT_NOME, map => map.MapFrom(y => y.AUT_NOME))
                .ForMember(x => x.CID, map => map.MapFrom(y => y.CID));
            CreateMap<AutorModel, Autor>()
                .ForMember(x => x.AUT_ID, map => map.MapFrom(y => y.AUT_ID))
                .ForMember(x => x.AUT_IDADE, map => map.MapFrom(y => y.AUT_IDADE))
                .ForMember(x => x.AUT_NOME, map => map.MapFrom(y => y.AUT_NOME))
                .ForMember(x => x.CID, map => map.MapFrom(y => y.CID));

            CreateMap<Noticia, NoticiaModel>()
                .ForMember(x => x.NOT_ID, map => map.MapFrom(y => y.NOT_ID))
                .ForMember(x => x.NOT_DATA, map => map.MapFrom(y => y.NOT_DATA))
                .ForMember(x => x.NOT_TEXTO, map => map.MapFrom(y => y.NOT_TEXTO))
                .ForMember(x => x.NOT_TITULO, map => map.MapFrom(y => y.NOT_TITULO))
                .ForMember(x => x.AUT, map => map.MapFrom(y => y.AUT))
                .ForMember(x => x.CAT, map => map.MapFrom(y => y.CAT));
            CreateMap<NoticiaModel, Noticia>()
                .ForMember(x => x.NOT_ID, map => map.MapFrom(y => y.NOT_ID))
                .ForMember(x => x.NOT_DATA, map => map.MapFrom(y => y.NOT_DATA))
                .ForMember(x => x.NOT_TEXTO, map => map.MapFrom(y => y.NOT_TEXTO))
                .ForMember(x => x.NOT_TITULO, map => map.MapFrom(y => y.NOT_TITULO))
                .ForMember(x => x.AUT, map => map.MapFrom(y => y.AUT))
                .ForMember(x => x.CAT, map => map.MapFrom(y => y.CAT));
        }
    }
}
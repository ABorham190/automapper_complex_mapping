using AutoMapper;
namespace complex_automapper.Models
{
    public class MyMappingProfile:Profile
    {

        public MyMappingProfile()
        {
            //Configure the Mappings
            CreateMap<Category, CategoryDTO>()
                .ForMember(dest => dest.ProductDTO, act => act.MapFrom(src => src.Products));
            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.ProductName, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.ProductPrice, act => act.MapFrom(src => src.Price));
        }

    }
}

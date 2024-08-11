using AutoMapper;
using Alex.Service.Models;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Product, ProductDto>(); // Убедитесь, что ProductDto существует в Alex.Service.Db
        CreateMap<ProductDto, Product>();
    }
}

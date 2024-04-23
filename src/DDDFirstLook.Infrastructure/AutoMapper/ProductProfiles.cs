using AutoMapper;
using DDDFirstLook.Domain.Products;
using DDDFirstLook.Infrastructure.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDFirstLook.Infrastructure.AutoMapper
{
    public class ProductProfiles : Profile
    {
        public ProductProfiles()
        {
            this.CreateMap<ProductDbEntity, Product>()
                .ReverseMap();
            this.CreateMap<AddressDbEntity, Address>().ReverseMap();
            this.CreateMap<AvailabilityDbEntity, Availability>().ReverseMap();
        }
    }
}

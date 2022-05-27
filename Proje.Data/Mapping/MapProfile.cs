using AutoMapper;
using Proje.Entity.DTOs;
using Proje.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Data.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Sparepart, SparepartDto>().ReverseMap();
            CreateMap<Partner, PartnerDto>().ReverseMap();
        }
    }
}

using System;
using AuthServer.Core.Dtos;
using AuthServer.Core.Models;
using AutoMapper;

namespace AuthServer.Service
{
	// default -> internal sadece bu assembler içerisinden erişilir
	class DtoMapper : Profile
	{
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
			CreateMap<UserAppDto, UserApp>().ReverseMap();
		}
	}
}


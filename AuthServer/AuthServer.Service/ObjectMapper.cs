using System;
using AutoMapper;

namespace AuthServer.Service
{
	public static class ObjectMapper
	{
		// ben datayı alana kadar memoryde bulunmasın static class
		// sadece ihityacım olduğu anda yüklesin -> lazy loading
		private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
		  {
			//action delegeler parametre alan ama geriye bir şey dönmeyen metodları işaret eder
			var config = new MapperConfiguration(cfg =>
			  {
				  cfg.AddProfile<DtoMapper>();
			  });
			  return config.CreateMapper();
		  });

		public static IMapper Mapper => lazy.Value;
	}
}


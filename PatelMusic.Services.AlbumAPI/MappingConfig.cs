using AutoMapper;
using PatelMusic.Services.AlbumAPI.Models;
using PatelMusic.Services.AlbumAPI.Models.DTO;

namespace PatelMusic.Services.AlbumAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<AlbumDto, Album>();
                config.CreateMap<Album, AlbumDto>();
            });

            return mappingConfig;
        }
    }
}
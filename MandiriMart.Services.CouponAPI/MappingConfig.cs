using AutoMapper;
using MandiriMart.Services.CouponAPI.Models;
using MandiriMart.Services.CouponAPI.Models.Dto;

namespace MandiriMart.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}

using Restaurant.Web.Dto;
using Restaurant.Web.Service.IService;
using Restaurant.Web.Utility;

namespace Restaurant.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.POST,
                Data = couponDto,
                Url = StaticDetails.CouponApiBase + "/api/coupon/"
            }) ;
        }

        public async Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.Delete,
                Url = StaticDetails.CouponApiBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponApiBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponApiBase + "/api/coupon/GetByCode" + couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponApiBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.StaticDetails.ApiType.Put,
                Data = couponDto,
                Url = StaticDetails.CouponApiBase + "/api/coupon/" 
            }) ;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Restaurant.Web.Service.IService;

namespace Restaurant.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;
        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

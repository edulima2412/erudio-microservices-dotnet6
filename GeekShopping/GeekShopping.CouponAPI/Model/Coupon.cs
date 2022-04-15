using GeekShopping.CouponAPI.Model.Base;

namespace GeekShopping.CouponAPI.Model
{

    public class Coupon : BaseEntity
    {
        public string CouponCode { get; set; }

        public decimal DiscountAmount { get; set; }
    }
}

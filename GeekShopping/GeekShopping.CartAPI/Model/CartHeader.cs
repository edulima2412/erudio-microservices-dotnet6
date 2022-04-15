using GeekShopping.CartAPI.Model.Base;

namespace GeekShopping.CartAPI.Model
{
    public class CartHeader : BaseEntity
    {
        public Guid UserId { get; set; }

        public string? CouponCode { get; set; }
    }
}

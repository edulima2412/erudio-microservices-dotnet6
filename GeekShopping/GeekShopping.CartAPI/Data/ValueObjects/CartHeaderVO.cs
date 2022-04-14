namespace GeekShopping.CartAPI.Data.ValueObjects
{
    public class CartHeaderVO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? CouponCode { get; set; }
    }
}

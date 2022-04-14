namespace GeekShopping.Web.Models
{
    public class CartHeaderViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string CouponCode { get; set; }
        public double PurchaseAmount { get; set; }
    }
}

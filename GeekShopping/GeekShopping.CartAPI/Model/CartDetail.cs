using GeekShopping.CartAPI.Model.Base;

namespace GeekShopping.CartAPI.Model
{
    public class CartDetail : BaseEntity
    {
        public Guid CartHeaderId { get; set; }

        public virtual CartHeader CartHeader { get; set; }

        public Guid ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Count { get; set; }
    }
}

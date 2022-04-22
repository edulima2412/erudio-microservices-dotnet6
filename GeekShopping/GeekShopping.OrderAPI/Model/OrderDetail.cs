using GeekShopping.OrderAPI.Model.Base;

namespace GeekShopping.OrderAPI.Model
{
    public class OrderDetail : BaseEntity
    {
        public Guid OrderHeaderId { get; set; }

        public virtual OrderHeader OrderHeader { get; set; }

        public Guid ProductId { get; set; }

        public int Count { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }
    }
}

using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Model
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        [Range(1,10000)]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        public string? CategoryName { get; set; }

        public string? ImageURL { get; set; }
    }
}

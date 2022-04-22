using GeekShopping.CartAPI.Data.ValueObjects;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartVO> FindCartByUserId(Guid userId);
        Task<CartVO> SaveOrUpdateCart(CartVO cart);
        Task<bool> RemoveFromCart(Guid cartDetailsId);
        Task<bool> ApplyCoupon(Guid userId, string couponCode);
        Task<bool> RemoveCoupon(Guid userId);
        Task<bool> ClearCart(Guid userId);
    }
}

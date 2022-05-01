using GeekShopping.Email.Model;

namespace GeekShopping.Email.Repository
{
    public interface IEmailRepository
    {
        Task UpdateOrderPaymentStatus(Guid headerId, bool status);
    }
}

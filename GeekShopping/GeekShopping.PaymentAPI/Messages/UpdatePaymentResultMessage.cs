using GeekShopping.MessageBus;

namespace GeekShopping.PaymentAPI.Messages
{
    public class UpdatePaymentResultMessage : BaseMessage
    {
        public Guid OrderId { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}

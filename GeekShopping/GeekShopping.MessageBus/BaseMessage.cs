namespace GeekShopping.MessageBus
{
    public class BaseMessage
    {
        public Guid Id { get; set; }
        public DateTime MessageCreated { get; set; } = DateTime.Now;
    }
}

using GeekShopping.Email.Model;
using GeekShopping.Email.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Email.Repository
{
    public class EmailRepository : IEmailRepository
    {
        private readonly DbContextOptions<MySqlContext> _context;

        public EmailRepository(DbContextOptions<MySqlContext> context)
        {
            _context = context;
        }

        public async Task UpdateOrderPaymentStatus(Guid headerId, bool status)
        {
            //await using var _db = new MySqlContext(_context);
            //var header = await _db.Headers.FirstOrDefaultAsync(o => o.Id == headerId);
            //if (header != null)
            //{
            //    header.PaymentStatus = status;
            //    await _db.SaveChangesAsync();
            //}
        }
    }
}

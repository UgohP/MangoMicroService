using Microsoft.EntityFrameworkCore;

namespace Mango.CouponAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Coupon>().HasData(
                new Models.Coupon
                {
                    CouponId = 1,
                    CouponCode = "10OFFF",
                    DiscountAmount = 10.0,
                    MinAmount = 100
                },
                new Models.Coupon
                {
                    CouponId = 2,
                    CouponCode = "20OFF",
                    DiscountAmount = 20.0,
                    MinAmount = 200
                }
            );
        }
    }
}

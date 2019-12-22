using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get;set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<User>()
                .HasData(
                    new User {Id=1, mobileCountryCode = "91", mobileNumber="8220644661", contactName="Mohideen Abdul Katheer M",
                    companyName="IG", companyType="IT", naupliiSupplier="None", country="India", state="Tamilnadu",
                    area="Dindigul", address="Paraipatty", referralCode="None"},

                    new User {Id=2, mobileCountryCode = "91", mobileNumber="9789161541", contactName="Dhanalakshmi N",
                    companyName="Accenture", companyType="IT", naupliiSupplier="None", country="India", state="Tamilnadu",
                    area="Chennai", address="TNagar", referralCode="None"}
                );
        }
    }
}
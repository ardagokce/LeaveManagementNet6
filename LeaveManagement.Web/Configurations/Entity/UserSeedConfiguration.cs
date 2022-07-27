using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entity
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "8ee0a8c8-4db6-496b-ba22-7bc092e055d3",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    NormalizedUserName = "ADMIN@TEST.COM",
                    UserName = "admin@test.com",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "dec2151b-add8-461c-ba74-b4e046ead07b",
                    Email = "arda@test.com",
                    NormalizedEmail = "ARDA@TEST.COM",
                    NormalizedUserName = "ARDA@TEST.COM",
                    UserName = "arda@test.com",
                    Firstname = "Arda",
                    Lastname = "Gokce",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }); 
        }
    }
}
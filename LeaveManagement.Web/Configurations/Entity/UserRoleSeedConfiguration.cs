using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entity
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "9ef0b8a8-5db7-387b-cb42-9dc125d064f3",
                    UserId = "8ee0a8c8-4db6-496b-ba22-7bc092e055d3"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "8fa1a8c8-3db2-496e-ce42-6da139a156c3",
                    UserId = "dec2151b-add8-461c-ba74-b4e046ead07b"
                });
        }
    }
}
using Micorsoft.AspNetCore.Identity.EntityFrameWorkCore

namespace Hospital.Repositories
{
    public class ApplicationDbContext : IdentityDbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
    }
}
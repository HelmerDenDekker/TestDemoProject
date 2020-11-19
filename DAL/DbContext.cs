using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DbContext
    {

        public DbSet<User> Users { get; set; }
    }
}
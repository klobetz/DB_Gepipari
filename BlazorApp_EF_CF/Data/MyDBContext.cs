using BlazorApp_EF_CF.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_EF_CF.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        DbSet<User> users { get; set; }

    }
}

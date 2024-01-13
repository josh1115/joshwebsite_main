
using Microsoft.EntityFrameworkCore;



namespace joshwebsite_main.Data

{
    public class MyApplicationDbContext : DbContext
    {
        public MyApplicationDbContext(DbContextOptions<MyApplicationDbContext> options) : base(options)
        {


        }






    }
}

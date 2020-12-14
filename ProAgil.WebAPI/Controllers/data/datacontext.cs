using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.model;

namespace ProAgil.WebAPI.Controllers.data
{
    public class datacontext : DbContext
    {
        public datacontext(DbContextOptions<datacontext>options): base(options){}

            public DbSet<evento> eventos { get; set; }
            
    }
    
}



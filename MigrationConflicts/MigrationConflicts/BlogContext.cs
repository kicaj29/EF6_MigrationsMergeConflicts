using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationConflicts
{
    public class BlogContext : DbContext
    {
        public BlogContext():base(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=BlogContext;Integrated Security=True")
        {

        }

        public DbSet<Blog> Blogs { get; set; }
    }
}

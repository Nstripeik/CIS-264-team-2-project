using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Team2Library
{
   public class BooksContext : DbContext
    {public BooksContext(string nameOrConnectionString): base(nameOrConnectionString)
        {

        }
        public DbSet<Books> book { get; set; }
    }
}

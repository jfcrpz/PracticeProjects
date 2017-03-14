using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data
{
    public class ToyInventoryContext : DbContext
    {
        public ToyInventoryContext() : base() { }
        public DbSet<Toy> Toys { get; set; }
        public  DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ContactPerson> ContactPersons { get; set; }

    }
}

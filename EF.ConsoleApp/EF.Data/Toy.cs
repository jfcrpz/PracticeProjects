using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data
{
    public class Toy
    {
        public int ToyId { get; set; }
        public string ToyName { get; set; }
        public string Description { get; set; }
        public string ToyType { get; set; }

        public Supplier Supplier { get; set; }

    }
}

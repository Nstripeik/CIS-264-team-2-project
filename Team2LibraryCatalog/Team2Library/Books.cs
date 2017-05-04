using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2Library
{
    public class Books 
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public bool Checkout { get; set; }

        public string Location { get; set; }
         public List<string> Author { get; set; }

        public string Description { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingPizza.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public int PizzaSupplierId { get; set; }
        public string Size { get; set; }
        //enum for size
        public string Toppings { get; set; }
    }
}

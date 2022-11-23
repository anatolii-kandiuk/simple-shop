using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_shop.Models;

namespace simple_shop.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Descriprion { get; set; }
    
        public List<Car> Cars { get; set; }
    }
}
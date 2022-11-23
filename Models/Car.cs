using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_shop.Models;

namespace simple_shop.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }
    
        public string ImgUrl { get; set; }

        public ushort Price { get; set; }

        public bool IsFavourite { get; set; }

        public bool Available { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
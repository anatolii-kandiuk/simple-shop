using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_shop.Models;

namespace simple_shop.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> getAllCategories { get; }  
    }
}
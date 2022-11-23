using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_shop.Interfaces;
using simple_shop.Models;

namespace simple_shop.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> getAllCategories
        {
            get 
            {
                return new List<Category> 
                {
                    new Category { Name = "Electric Car", Descriprion = "Cars with an electric motor" },
                    new Category { Name = "Classic Car", Descriprion = "Cars with internal combustion engine" }
                };
            }
        }
    }
}
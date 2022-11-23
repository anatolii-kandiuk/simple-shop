using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_shop.Interfaces;
using simple_shop.Models;

namespace simple_shop.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _CategoryCars = new MockCategory();
        
        public IEnumerable<Car> Cars 
        { 
            get 
            {
                return new List<Car>
                {
                    new Car 
                    {
                        Name = "Tesla Model S", 
                        ShortDescription = "", 
                        LongDescription = "", 
                        ImgUrl = "", 
                        Price = 45000, 
                        IsFavourite = true, 
                        Available = true, 
                        Category = _CategoryCars.getAllCategories.First() 
                    },
                    new Car 
                    {
                        Name = "Ford Fiesta", 
                        ShortDescription = "", 
                        LongDescription = "", 
                        ImgUrl = "", 
                        Price = 45000, 
                        IsFavourite = true, 
                        Available = true, 
                        Category = _CategoryCars.getAllCategories.First() 
                    },
                    new Car 
                    {
                        Name = "BMW M3", 
                        ShortDescription = "", 
                        LongDescription = "", 
                        ImgUrl = "", 
                        Price = 45000, 
                        IsFavourite = true, 
                        Available = true, 
                        Category = _CategoryCars.getAllCategories.First() 
                    },
                };
            }

            
        }
        public IEnumerable<Car> getFavoriteCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
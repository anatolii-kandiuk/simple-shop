using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using simple_shop.Models;

namespace simple_shop.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        
        IEnumerable<Car> getFavoriteCars { get; set; }

        Car getObjectCar(int carId); 
    }
}
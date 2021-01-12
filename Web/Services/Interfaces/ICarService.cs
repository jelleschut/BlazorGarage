using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services.Interfaces
{
    public interface ICarService
    {
        Task Add(Car car);
        Task Update(Car car);
        Task<Car> Find(int id);
        Task<IEnumerable<Car>> GetAll();
        Car EncryptCar(Car car);
        Car DecryptCar(Car car);
    }
}

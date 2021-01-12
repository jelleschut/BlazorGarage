using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Services.Interfaces;
using Web.Utils;

namespace Web.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IOwnerRepository _ownerRepository;
        private IOwnerService _ownerService;
        private X509Encryptor encryptor;

        public CarService(ICarRepository carRepository, IOwnerRepository ownerRepository, IOwnerService ownerService)
        {
            _carRepository = carRepository;
            _ownerRepository = ownerRepository;
            _ownerService = ownerService;
            encryptor = new X509Encryptor();
        }

        public async Task Add(Car car)
        {
            car.Owner = await _ownerRepository.FindAsync(car.OwnerId);
            car.Driver = await _ownerRepository.FindAsync(car.DriverId);
            car.Driver = null;
            car.Owner = null;

            await _carRepository.AddAsync(EncryptCar(car));
        }

        public async Task<Car> Find(int id)
        {
            return DecryptCar(await _carRepository.FindAsync(id));
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            IEnumerable<Car> cars = await _carRepository.GetAllAsync();
            List<Car> decryptedCars = new List<Car>();

            foreach(Car car in cars)
            {
                decryptedCars.Add(DecryptCar(car));
            }

            return decryptedCars;
        }

        public async Task Update(Car car)
        {
            await _carRepository.UpdateAsync(EncryptCar(car));
        }

        public Car EncryptCar(Car car)
        {
            Car encryptedCar = car;
            encryptedCar.LicenseNumber = encryptor.Encrypt(car.LicenseNumber);

            return encryptedCar;
        }

        public Car DecryptCar(Car car)
        {
            car.LicenseNumber = encryptor.Decrypt(car.LicenseNumber);
            car.Owner = _ownerService.DecryptOwner(car.Owner);
            car.Driver = _ownerService.DecryptOwner(car.Driver);

            return car;
        }
    }
}

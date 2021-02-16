using System;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car{Id=1,BrandID=2,ColorId=2,DailyPrice=246.000m,Description="fast",ModelYear=2021},
                new Car{Id=2,BrandID=1,ColorId=3,DailyPrice=346.000m,Description="lux",ModelYear=2021},
                new Car{Id=3,BrandID=1,ColorId=3,DailyPrice=146.000m,Description="midWell",ModelYear=2021},
                new Car{Id=4,BrandID=2,ColorId=2,DailyPrice=200.000m,Description="normal",ModelYear=2021},
                new Car{Id=5,BrandID=1,ColorId=3,DailyPrice=150.000m,Description="nice",ModelYear=2021},
                new Car{Id=6,BrandID=2,ColorId=1,DailyPrice=100.000m,Description="cheap",ModelYear=2021}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByCategory(int Id)
        {
            return _car.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}

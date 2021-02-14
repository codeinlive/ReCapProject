using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car{Id=1,  DailyPrice=3000, ColorId=21, Description="white toyota car",ModelYear=2001 },
                new Car { Id = 2, DailyPrice = 7000, ColorId = 56, Description = "red alfa romeo car", ModelYear = 2019 },
                new Car { Id = 3, DailyPrice = 8000, ColorId = 4, Description = "purple bmw car", ModelYear = 2020 },
                new Car { Id = 4, DailyPrice = 4500, ColorId = 7, Description = "yellow nissan car", ModelYear = 2017 },
                new Car { Id = 5, DailyPrice = 55000, ColorId = 11, Description = "black ferrari car", ModelYear = 2000 }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByld(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

      
    }
}

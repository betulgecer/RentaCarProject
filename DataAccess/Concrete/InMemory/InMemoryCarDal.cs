using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
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
            _cars = new List<Car> {
            new Car {CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 86,  ModelYear = 2010, Description = "Pert" },
            new Car {CarId = 2, BrandId = 1, ColorId = 6, DailyPrice = 95,  ModelYear = 2012, Description = "İyi durumda" },
            new Car {CarId = 3, BrandId = 2, ColorId = 1, DailyPrice = 102, ModelYear = 2014, Description = "Normal" },
            new Car {CarId = 4, BrandId = 3, ColorId = 4, DailyPrice = 110, ModelYear = 2016, Description = "Hasarlı" },
            new Car {CarId = 5, BrandId = 5, ColorId = 2, DailyPrice = 170, ModelYear = 2019, Description = "Çok iyi" },
            new Car {CarId = 6, BrandId = 9, ColorId = 1, DailyPrice = 200, ModelYear = 2020, Description = "Mükemmel !!!" }};  
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }


        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
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

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
        }
    }
}

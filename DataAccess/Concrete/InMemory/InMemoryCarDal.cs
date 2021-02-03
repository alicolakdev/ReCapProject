using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;


        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId= 1, ColorId=1, DailyPrice=200000, Description="Audi A3", ModelYear=2010},
                new Car {Id = 2, BrandId= 1, ColorId=2, DailyPrice=300000, Description="Audi A5", ModelYear=2015},
                new Car {Id = 3, BrandId= 2, ColorId=3, DailyPrice=100000, Description="Honda Civic", ModelYear=2010},
                new Car {Id = 4, BrandId= 2, ColorId=4, DailyPrice=150000, Description="Honda Accord", ModelYear=2013},
                new Car {Id = 5, BrandId= 3, ColorId=5, DailyPrice=250000, Description="Mercedes C180", ModelYear=2011},
                new Car {Id = 6, BrandId= 3, ColorId=6, DailyPrice=300000, Description="Mercedes E220", ModelYear=2012},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car car1 = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car1);
        }


        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car car1 = _cars.SingleOrDefault(c => c.Id == car.Id);
            car1.ColorId = car.ColorId;
            car1.BrandId = car.BrandId;
            car1.DailyPrice = car.DailyPrice;
            car1.Description = car.Description;
            car1.ModelYear = car1.ModelYear;

        }


        public List<Car> GetAllByBrand(int brandId)
        {
            var carsByBrand = _cars.Where(cB => cB.BrandId == brandId).ToList();
            return carsByBrand;
        }

        public List<Car> GetAllByColor(int colorId)
        {
            var carsByColor = _cars.Where(cB => cB.ColorId == colorId).ToList();
            return carsByColor;
        }
    }
}

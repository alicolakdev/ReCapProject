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
        List<Brand> _brands;
        List<Color> _colors;

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

            _brands = new List<Brand>
            {
                new Brand {Id= 1, Name = "Audi"},
                new Brand {Id= 2, Name = "Honda"},
                new Brand {Id= 3, Name = "Mercedes"},
            };

            _colors = new List<Color>
            {
                new Color{Id=1, Name="Black"},
                new Color{Id=2, Name="White"},
                new Color{Id=3, Name="Red"},
                new Color{Id=4, Name="Grey"},
                new Color{Id=5, Name="Blue"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Yeni araba eklendi : " + car.Description);
        }

        public void Delete(Car car)
        {
            Car car1 = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car1);
            Console.WriteLine("Araba silme işlemi tamamlandı");
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car car1 = _cars.SingleOrDefault(c => c.Id == car.Id);
            car1.Id = car.Id;
            car1.ColorId = car.ColorId;
            car1.BrandId = car.BrandId;
            car1.DailyPrice = car.DailyPrice;
            car1.Description = car.Description;
            car1.ModelYear = car1.ModelYear;

            Console.WriteLine("Araba bilgileri güncellendi :" + car1.Description);
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

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}

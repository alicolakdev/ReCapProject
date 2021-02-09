using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.Name.Length >= 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("{0} - Marka adı başarıyla eklendi", brand.Name);
            }
            else
            {
                Console.WriteLine($"marka ismini 2 harften fazla giriniz {brand.Name}");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("{0} - Marka adı başarıyla silindi", brand.Name);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine("{0} - Marka adı başarıyla güncellendi", brand.Name);
        }

        public List<Brand> GetAll()
        {
            Console.WriteLine("*********** Car Brand List ***********");
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b => b.Id == id);
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("{0} - Renk adı başarıyla eklendi", color.Name);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("{0} - Renk adı başarıyla silindi", color.Name);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("{0} - Renk adı başarıyla güncellendi", color.Name);
        }

        public List<Color> GetAll()
        {
            Console.WriteLine("*********** Car Color List ***********");
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c => c.Id == id);
        }
    }
}


// DataAccess ürünü ekleyecek
// Business kontrol edecek
// Console ürünü gösterecek
// Entities yardımcı katmanımız olacak. Diğer 3 katman bu entities'i kullanacak


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
                new Car{Id=1,BrandId=1,ColorId=45,DailyPrice=300,ModelYear=2017,Description="test araç 1"},
                new Car{Id=2,BrandId=1,ColorId=34,DailyPrice=250,ModelYear=2015,Description="test araç 2"},
                new Car{Id=3,BrandId=2,ColorId=12,DailyPrice=450,ModelYear=2020,Description="test araç 3"},
                new Car{Id=4,BrandId=2,ColorId=32,DailyPrice=350,ModelYear=2019,Description="test araç 4"},
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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

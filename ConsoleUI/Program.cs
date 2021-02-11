// DataAccess ürünü ekleyecek
// Business kontrol edecek
// Console ürünü gösterecek
// Entities yardımcı katmanımız olacak. Diğer 3 katman bu entities'i kullanacak

using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.DailyPrice + " ve " + car.ModelYear);

            }


            //Araç ekleme
            Car car1 = new Car() { Id = 5, BrandId = 3, ColorId = 18, DailyPrice = 500, Description = "test yeni ekle", ModelYear = 2021 };
            carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Id + " ," + car.BrandId + " ," + car.ColorId + " ," + car.DailyPrice + " ," + car.ModelYear + " ," + car.Description);

            }

            //Araç Güncelleme

            Car car2 = new Car() { Id = 1, BrandId = 1, ColorId = 45, DailyPrice = 300, ModelYear = 2017, Description = "test güncelle" };


            foreach (var car in carManager.GetAll())
            {
                if (car.Id.Equals(1))
                {
                    System.Console.WriteLine(car.Id + " ," + car.BrandId + " ," + car.ColorId + " ," + car.DailyPrice + " ," + car.ModelYear + " ," + car.Description);
                    carManager.Update(car2);
                    System.Console.WriteLine(Environment.NewLine);
                }
                System.Console.WriteLine(car.Id + " ," + car.BrandId + " ," + car.ColorId + " ," + car.DailyPrice + " ," + car.ModelYear + " ," + car.Description);


            }

            //Araç silme
            carManager.Delete(car1);
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Id + " ," + car.BrandId + " ," + car.ColorId + " ," + car.DailyPrice + " ," + car.ModelYear + " ," + car.Description);

            }

        }
    }
}
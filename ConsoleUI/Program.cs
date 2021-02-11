using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Öncesinde: ");
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Descriptions + " Günlük Fiyat: " + c.DailyPrice + "$");
            }
            Car car = new Car {BrandId = 3, ColorId = 1, DailyPrice = 120, Descriptions = "Porsche", ModelYear = 2021 };
            carManager.Add(car);
            Console.WriteLine("İşlem ekledikten sonra: ");
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Descriptions + " Günlük Fiyat: " + c.DailyPrice + "$");
            }
            car.DailyPrice = 100;
            carManager.Update(car);
            Console.WriteLine("İşlemi güncelledikten sonra: ");
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Descriptions + " Günlük Fiyat: " + c.DailyPrice + "$");
            }
            carManager.Delete(car);
            Console.WriteLine("Silme işleminden sonra:");
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Descriptions + " Günlük Fiyat: " + c.DailyPrice + "$");
            }
            Console.WriteLine("-----------------------------------------------");

            foreach (var c in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(c.Descriptions);
            }
            Console.WriteLine("-----------------------------------------------");

            foreach (var c in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(c.Descriptions);
            }
            Console.WriteLine("-----------------------------------------------");


        }
    }
}

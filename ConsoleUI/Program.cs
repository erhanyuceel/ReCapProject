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
            //CarTest();
            BrandTest();
            //ColorTest();
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //Liste
            Console.WriteLine("Renkler Öncesinde: ");
            foreach (var c in colorManager.GetAll().Data)
            {
                Console.WriteLine(c.ColorId + " Renk: " + c.ColorName);
            }
            Console.WriteLine("-----------------------------------------------");

            //Ekle
            Color color = new Color { ColorName = "Mavi" };
            colorManager.Add(color);
            Console.WriteLine("İşlem ekledikten sonra: ");
            foreach (var c in colorManager.GetAll().Data)
            {
                Console.WriteLine(c.ColorId + " Renk: " + c.ColorName);
            }
            Console.WriteLine("-----------------------------------------------");

            //Güncelle
            color.ColorName = "Yeşil";
            colorManager.Update(color);
            Console.WriteLine("İşlemi güncelledikten sonra: ");
            foreach (var c in colorManager.GetAll().Data)
            {
                Console.WriteLine(c.ColorId + " Renk: " + c.ColorName);
            }
            Console.WriteLine("-----------------------------------------------");

            //Sil
            colorManager.Delete(color);
            Console.WriteLine("Silme işleminden sonra:");
            foreach (var c in colorManager.GetAll().Data)
            {
                Console.WriteLine(c.ColorId + " renk: " + c.ColorName);
            }
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine(colorManager.GetById(1).Data.ColorName);
            Console.WriteLine("-----------------------------------------------");
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Liste
            Console.WriteLine("Markalar Öncesinde: ");
            foreach (var c in brandManager.GetAll().Data)
            {
                Console.WriteLine(c.BrandId + " Marka: " + c.BrandName);
            }
            Console.WriteLine("-----------------------------------------------");

            //Ekle
            Brand brand = new Brand { BrandName = "Porshe"};
            brandManager.Add(brand);
            Console.WriteLine("İşlem ekledikten sonra: ");
            foreach (var c in brandManager.GetAll().Data)
            {
                Console.WriteLine(c.BrandId + " Marka: " + c.BrandName);
            }
            Console.WriteLine("-----------------------------------------------");

            //Güncelle
            brand.BrandName = "Opel";
            brandManager.Update(brand);
            Console.WriteLine("İşlemi güncelledikten sonra: ");
            foreach (var c in brandManager.GetAll().Data)
            {
                Console.WriteLine(c.BrandId + " Marka: " + c.BrandName);
            }
            Console.WriteLine("-----------------------------------------------");

            //Sil
            brandManager.Delete(brand);
            Console.WriteLine("Silme işleminden sonra:");
            foreach (var c in brandManager.GetAll().Data)
            {
                Console.WriteLine(c.BrandId + " Marka: " + c.BrandName);
            }
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine(brandManager.GetById(1).Data.BrandName);
            Console.WriteLine("-----------------------------------------------");
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var c in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(c.Id + " / " + c.CarName + " / " + c.BrandName + " / " + c.ColorName + " / " + c.Descriptions + " / Günlük Fiyat: " + c.DailyPrice + "TL");
            }
            Console.WriteLine("-----------------------------------------------");

            //Liste
            Console.WriteLine("Öncesinde: ");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.Id + "" + c.Descriptions + " Günlük Fiyat: " + c.DailyPrice + "TL");
            }
            Console.WriteLine("-----------------------------------------------");

            //Ekle
            Car car = new Car {BrandId = 1, ColorId = 2, DailyPrice = 200, Descriptions = "Deneme", ModelYear = 2021, CarName="Temiz Araba" };
            carManager.Add(car);
            Console.WriteLine("İşlem ekledikten sonra: ");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.Id + " " + c.Descriptions + " Günlük Fiyat: " + c.DailyPrice + "TL");
            }
            Console.WriteLine("-----------------------------------------------");
            
            //Güncelle
            car.Descriptions = "Deneme Test";
            carManager.Update(car);
            Console.WriteLine("İşlemi güncelledikten sonra: ");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.Id + " " + c.Descriptions + " Günlük Fiyat: " + c.DailyPrice + "TL");
            }
            Console.WriteLine("-----------------------------------------------");

            //Sil
            carManager.Delete(car);
            Console.WriteLine("Silme işleminden sonra:");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.Id + " " + c.Descriptions + " Günlük Fiyat: " + c.DailyPrice + "TL");
            }
            Console.WriteLine("-----------------------------------------------");

            
            foreach (var c in carManager.GetByBrandID(3).Data)
            {
                Console.WriteLine(c.Descriptions);
            }
            Console.WriteLine("-----------------------------------------------");

            foreach (var c in carManager.GetByColorID(2).Data)
            {
                Console.WriteLine(c.Descriptions);
            }
            Console.WriteLine("-----------------------------------------------");

        }
    }
}

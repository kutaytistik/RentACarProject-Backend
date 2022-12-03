using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ICarDal carDal = new EfCarDal();
            CarManager carManager = new CarManager(carDal);
            



            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+"/"+car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }




            Console.ReadLine();
        }
    }
}

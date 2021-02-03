﻿using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var carManager = new CarManager(new InMemoryProductDal());
            Write(carManager,"Default");
            //Add Test
            carManager.Add(new Car { CarId = 6, BrandId = 1, ColorId = 2, DailyPrice = 50000, Description = "NEW CAR", ModelYear = 2021 });
            Write(carManager,"Added");


            //Delete Test
            carManager.Delete(new Car { CarId = 6 });
            Write(carManager,"Deleted");

            //Update Test
            carManager.Update(new Car { CarId = 5, BrandId = 5, ColorId = 3, DailyPrice = 70000, Description = "UPDATED CAR", ModelYear = 2021 });
            Write(carManager,"Updated");

            //GetByID Test
            Console.WriteLine("------------------------------GetByID--------------------------------------------------");
            foreach (var car in carManager.GetById(3))
            {
                Console.WriteLine("CarID: {0} MarkaID: {1} ColorId: {2} DailyPrice: {3} Description: {4} ModelYear: {5}", car.CarId, car.BrandId, car.ColorId, car.DailyPrice, car.Description, car.ModelYear);
            }
        }


        static void Write(CarManager carManager, string Msg)
        {
            Console.WriteLine("------------------------------{0}--------------------------------------------------", Msg);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("CarID: {0} MarkaID: {1} ColorId: {2} DailyPrice: {3} Description: {4} ModelYear: {5}", car.CarId, car.BrandId, car.ColorId, car.DailyPrice, car.Description, car.ModelYear);
            }
        }
    }
}
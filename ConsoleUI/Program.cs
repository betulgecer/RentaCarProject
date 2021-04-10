using Business.Concrete;
using Core.Entities.Concrete;
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
            //Robert C. Martin Clean Code
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //CarTest();
            //BrandTest();
            //ColorTest();
            UserTest();

        }

        //private static void RentalTest()
        //{
        //    RentACarManager rentalManager = new RentACarManager(new EfRentACarDal());
        //    rentalManager.Insert(new Rental { RentDate = new DateTime(2021, 02, 20), CarId = 2, CustomerId = 2 });
        //    foreach (var rental in rentalManager.GetAll().Data)
        //    {
        //        Console.WriteLine(rental.RentDate);
        //    }
        //}

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            User user1 = new User();
            user1.FirstName = "Jack";
            user1.LastName = "Hugeman";
            user1.Email = "jkhgmn@mail.com";
            //user1.Password = "157835";

            User user2 = new User();
            user2.FirstName = "Natalia";
            user2.LastName = "Ihnatenko";
            user2.Email = "ihnatenko@mail.com";
            //user2.Password = "1145785";

            User user3 = new User();
            user3.FirstName = "Mehmet";
            user3.LastName = "Demir";
            user3.Email = "mmtdmr@mail.com";
            //user3.Password = "1478935";

            User user4 = new User();
            user4.FirstName = "Furkan";
            user4.LastName = "Kurt";
            user4.Email = "fkrt@mail.com";
            //user4.Password = "14786935";

            User user5 = new User();
            user5.FirstName = "Andrew";
            user5.LastName = "Popp";
            user5.Email = "andpopp@mail.com";
            //user5.Password = "471369";

            //userManager.Add(user1);
            //userManager.Add(user2);
            //userManager.Add(user3);
            //userManager.Add(user4);
            //userManager.Add(user5);


            //Console.WriteLine(userManager.Delete(new User { UserId = 7 }).Message);
            //foreach (var user in userManager.GetAll().Data)
            //{
            //Console.WriteLine(user.UserId + user.LastName);
            //}
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customerManager.Add(new Customer { UserId = 2, CustomerName = "Yazılım Atölyesi" }).Message);

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.UserId + " " + customer.CustomerName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var c = colorManager.GetById(2).Message;
            Console.WriteLine(c);
            Console.WriteLine("---------");
            foreach (var d in colorManager.GetAll().Data)
            {
                Console.WriteLine(d.ColorId + "/" + d.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var a = brandManager.GetById(3).Message;
            Console.WriteLine(a);
            Console.WriteLine("---------");
            foreach (var b in brandManager.GetAll().Data)
            {
                Console.WriteLine(b.BrandId + "/" + b.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car();
            car1.BrandId = 2;
            car1.ColorId = 2;
            car1.DailyPrice = 50;
            car1.Description = "Nissan";
            car1.ModelYear = 2017;

            Car car2 = new Car();
            car2.BrandId = 1;
            car2.ColorId = 2;
            car2.DailyPrice = 70;
            car2.Description = "Hyundai";
            car2.ModelYear = 2019;


            //carManager.Add(car1);
            //carManager.Add(car2);

            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.CarId + "/" + c.Description);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}

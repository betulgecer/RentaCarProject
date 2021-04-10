using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentACarDal : EfEntityRepositoryBase<Rental, RentaCarContext>, IRentACarDal
    {
        public RentalDetailDto GetRentalDetail(int id)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from rental in context.RentACars.Where(r => r.RentalId == id)

                             join car in context.Cars
                                 on rental.CarId equals car.CarId

                             join customer in context.Customers
                                 on rental.CustomerId equals customer.Id

                             join brand in context.Brands
                                 on car.BrandId equals brand.BrandId

                             join color in context.Colors
                                 on car.ColorId equals color.ColorId

                             join user in context.Users
                                 on customer.UserId equals user.UserId

                             select new RentalDetailDto
                             {
                                 RentalId = rental.RentalId,
                                 CarId = car.CarId,
                                 BrandName = brand.BrandName,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };

                return result.SingleOrDefault();
            }
        }

        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentaCarContext carContext = new RentaCarContext())
            {
                var result = from renta in carContext.RentACars
                             join custo in carContext.Customers
                             on renta.CustomerId equals custo.Id

                             join use in carContext.Users
                             on custo.UserId equals use.UserId

                             join car in carContext.Cars
                             on renta.CarId equals car.CarId

                             join brand in carContext.Brands
                             on car.BrandId equals brand.BrandId

                             select new RentalDetailDto
                             {
                                 RentalId = renta.RentalId,
                                 CarId = car.CarId,
                                 BrandName = brand.BrandName,
                                 Model = car.Model,
                                 CustomerId = custo.Id,
                                 FirstName = use.FirstName,
                                 LastName = use.LastName,
                                 RentDate = renta.RentDate,
                                 ReturnDate = renta.ReturnDate?? DateTime.Now
                             };

                return result.ToList();
            }
        }
    }
}

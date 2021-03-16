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
                                 BrandName = brand.BrandName,
                                 Model = car.Model,
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

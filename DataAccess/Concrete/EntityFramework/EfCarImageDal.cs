using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, RentaCarContext>, ICarImageDal
    {
        public List<CarImageDto> GetCarImageDetails(Expression<Func<CarImage, bool>> filter = null)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from i in filter == null ? context.CarImages : context.CarImages.Where(filter)
                             join cr in context.Cars
                             on i.CarId equals cr.CarId


                             select new CarImageDto
                             {
                                 CarId = cr.CarId,
                                 ImagePath = i.ImagePath
                             };
                return result.ToList();
            }
        }
    }
}

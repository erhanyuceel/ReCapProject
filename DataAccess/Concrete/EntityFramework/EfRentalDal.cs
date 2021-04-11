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

    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentDetails(Expression<Func<Rental, bool>> filter = null)
        {
            //Tabloları burada joinliyoruz.
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars on r.CarId equals c.Id
                             join cu in context.Customers on r.CustomerId equals cu.Id
                             join u in context.Users on cu.UserId equals u.UserId
                             select new RentalDetailDto
                             {
                                 RentId = r.Id,
                                 CarName = c.CarName,
                                 CarId = r.CarId,
                                 CompanyName = cu.CompanyName,
                                 CustomerName = u.FirstName +" "+ u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 DailyPrice = r.DailyPrice,
                                 TotalPrice = r.TotalPrice,
                             };
                return result.ToList();

            }
        }
    }
    
}

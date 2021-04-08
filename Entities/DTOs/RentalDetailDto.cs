using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentId { get; set; }
        public string CarName { get; set; }
        public int CarId { get; set; }
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public double DailyPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}

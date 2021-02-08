using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe7.Models
{
    /// <summary>
    /// Model of vacation offer
    /// </summary>
    public class VacationOffer
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string HotelName { get; set; }
        public int HotelRating { get; set; }
        public int Days { get; set; }
        public int Cost { get; set; }
    }
}

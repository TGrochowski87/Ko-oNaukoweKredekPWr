using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe7.Models
{
    /// <summary>
    /// Model of trip
    /// </summary>
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hotel { get; set; }
        public TimeSpan Time { get; set; }
        public int Cost { get; set; }
    }
}

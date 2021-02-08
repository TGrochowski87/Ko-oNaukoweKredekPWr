using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe3.ViewModels
{
    /// <summary>
    /// View model of Animals table
    /// </summary>
    public class AnimalViewModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string PopulationStatus { get; set; }
        public string Region { get; set; }
    }
}

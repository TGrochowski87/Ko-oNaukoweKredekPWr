using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe3.ViewModels
{
    /// <summary>
    /// View model of Keepers table
    /// </summary>
    public class KeeperViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public int Lodge { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe2
{
    interface IFight
    {
        /// <summary>
        /// A method responsible for damage calculation
        /// </summary>
        /// <param name="enemy">A fighter the calculated damage will be inflicted on</param>
        /// <returns></returns>
        int Fight(Fighter enemy);
    }
}

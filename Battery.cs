using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictofon
{
    class Battery
    {
        public int charge { get; set; }
        public Battery() 
        {
            charge = 75;
        }
    }
}

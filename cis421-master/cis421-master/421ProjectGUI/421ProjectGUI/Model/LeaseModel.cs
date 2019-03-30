using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421ProjectGUI.Model
{
    public class LeaseModel : DealModel
    {
        public string Contract { get; set; }
        public string End_Date { get; set; }
        public string Miles { get; set; }
    }
}

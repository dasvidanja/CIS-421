using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421ProjectGUI.Person
{
    public class People
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }

        //Maybe this is wrong  
        public string Address { set; get; }
    }

    public class Customer : People {

        public string BillinInfo { set; get; }
        public string License { set; get; }
        public string Insurance { set; get; }

    }
}

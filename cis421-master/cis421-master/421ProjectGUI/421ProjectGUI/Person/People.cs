﻿using System;
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
        public string Phone_Number { set; get; }

    }

    public class Customer : People {

        public string Billing_Info { set; get; }
        public string License_Number { set; get; }
        public string Insurance_Number { set; get; }

    }

    public class Employee : People
    {
        public string Employee_Discount { set; get; }
        public string Salary { set; get; }
    }

    public class Manager : Employee
    {
        public string Clearance_Level { set; get; }
    }

    public class SalesPerson : Employee
    {
        public string Managers_Id { get; set; }
        public string Yearly_Sales { get; set; }
    }
}

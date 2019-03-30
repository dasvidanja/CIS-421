using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421ProjectGUI.Model
{
    public class VehicleModel
    {
        public string Model { set; get; }
        public string Color { set; get; }
        public string Power_Source { set; get; }
        public string Mileage { set; get; }
        public string Condition { set; get; }
        public string Vin_Number { set; get; }
        public DateTime Year { set; get; }
    }

    public class CarModel : VehicleModel
    {
        public string Type { set; get; }
    }
    public class TruckModel : VehicleModel
    {
        public string Weight_Capacity { set; get; }
        public string Towing_Capacity { set; get; }
    }
}

using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace TrainReserveSystem.Models
{
    public class Train_For_Passenger
    {
        //DbSet<Train_For_Passenger> trains { get; set; }
        public int Train_Number { get; set; }
        public string Train_Name { get; set; }
        public double Fare { get; set; }

    }
}
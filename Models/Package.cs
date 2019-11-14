using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Package
    {
        //constructor
        public Package() { }

        public int PackageID { get; set; }                      //package id
        public string PackageName { get; set; }                 //package name
        public string PackageDesc { get; set; }                 //package description
        public DateTime? StartDate { get; set; }                //start date can be null
        public DateTime? EndDate { get; set; }                  //End date can be null
        public decimal BasePrice { get; set; }                  //Base price can't be null
        public decimal? AgencyCommission { get; set; }          //Agency commission can be null
    }
}

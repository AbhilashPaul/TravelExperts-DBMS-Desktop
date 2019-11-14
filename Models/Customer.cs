using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        public int CustomerId { get; set; }                      //customer id
        public string CustFirstName { get; set; }                //customer first name
        public string CustLastName { get; set; }                 //customer last name
        public string CustAddress { get; set; }                  //customer address
        public string CustCity { get; set; }
        public string CustProv { get; set; }
        public string CustPostal { get; set; }
        public string CustCountry { get; set; }
        public string CustHomePhone { get; set; }
        public string CustBusPhone { get; set; }
        public string CustEmail { get; set; }
        public int AgentId { get; set; }
    }
}

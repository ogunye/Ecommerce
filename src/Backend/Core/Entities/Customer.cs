using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customer : BaseEntity
    {
        [ForeignKey("Customer_Address")]
        public int address_id { get; set; }
        public virtual Customer_Address Customer_Address { get; set; }

        public string customerType { get; set; }
        public string organization_name { get; set; }
        public string gender { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string phone_number { get; set; }
    }
}

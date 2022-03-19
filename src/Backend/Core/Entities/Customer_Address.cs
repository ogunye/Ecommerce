using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customer_Address : BaseEntity
    {
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string address_line_3 { get; set; }
        public string city { get; set; }
        public string Country { get; set; }
    }
}

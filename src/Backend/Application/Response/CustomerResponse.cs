using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response
{
    public class CustomerResponse
    {
        public Int64 Id { get; set; }
        public int address_id { get; set; }        
        public string customerType { get; set; }
        public string organization_name { get; set; }
        public string gender { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string phone_number { get; set; }
    }
}

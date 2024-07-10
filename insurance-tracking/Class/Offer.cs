using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurance_tracking.Class
{
    public class Offer
    {
        public int offer_id { get; set; }
        public string customer_full_name { get; set; }
        public string insurance_type { get; set; }
        public string address { get; set; }
        public string document_no { get; set; }
        public string serial_no { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? end_date { get; set; }
        public decimal insure_amount { get; set; }
        public DateTime? issue_date { get; set; }
        public string plate { get; set; }
        public string referance_code { get; set; }
        public string uavt_code { get; set; }
    }
}

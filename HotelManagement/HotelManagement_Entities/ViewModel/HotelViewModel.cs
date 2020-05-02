using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_Entities.ViewModel
{
    class HotelViewModel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelCity { get; set; }
        public int HotelPinCode { get; set; }
        public long ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string HotelWebsite { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_Entities.ViewModel
{
    public class BookingViewModel
    {
        public int BookingId { get; set; }
        public Nullable<int> RoomId { get; set; }
        public System.DateTime BookingDate { get; set; }
        public string BookingStatus { get; set; }
    }
}

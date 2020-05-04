using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement_Entities.Models;
using HotelManagement_Entities.ViewModel;

namespace HotelManagement_BL.Interface
{
    public interface IBLBooking
    {
        List<BookingViewModel> GetBookings();
        BookingViewModel GetBooking(int id);
        List<BookingViewModel> GetBookings(DateTime date, int? roomid, int? hotelid);
        bool AddBooking(BookingViewModel booking);
        bool UpdateBooking(BookingViewModel booking);
        bool DeleteBooking(int id);
    }
}

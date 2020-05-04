using HotelManagement_Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_DL.Interface
{
    public interface IBLBooking
    {
        IQueryable<Booking> GetAllBookings();
        Booking GetBooking(int id);
        bool UpdateBooking(Booking booking);
        bool AddBooking(Booking booking);
        bool DeleteBooking(int id);
    }
}

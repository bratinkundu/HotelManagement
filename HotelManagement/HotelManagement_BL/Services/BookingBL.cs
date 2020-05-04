using HotelManagement_BL.Interface;
using HotelManagement_DL.Services;
using HotelManagement_Entities.ViewModel;
using HotelManagement_Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_BL.Services
{
    public class BookingBL : IBLBooking
    {
        private BookingDL bookingdl;
        public BookingBL(BookingDL _bookingdl)
        {
            bookingdl = _bookingdl;
        }

        public bool AddBooking(BookingViewModel booking)
        {
            return bookingdl.AddBooking(Mapper.Map<BookingViewModel, Booking>(booking));
        }

        public bool DeleteBooking(int id)
        {
            return bookingdl.DeleteBooking(id);
        }

        public BookingViewModel GetBooking(int id)
        {
            return Mapper.Map<Booking, BookingViewModel>(bookingdl.GetBooking(id));
        }

        public List<BookingViewModel> GetBookings()
        {
            List<Booking> booking = bookingdl.GetAllBookings().ToList();
            List<BookingViewModel> bookingvm = new List<BookingViewModel>();

            foreach(Booking book in booking)
            {
                bookingvm.Add(Mapper.Map<Booking, BookingViewModel>(book));
            }
            return bookingvm;
        }

        public List<BookingViewModel> GetBookings(Nullable<DateTime> date, int? roomid, int? hotelid)
        {
            IQueryable<Booking> bookings = bookingdl.GetAllBookings();
            List<BookingViewModel> bookingvm = new List<BookingViewModel>();
            if (roomid != null)
                bookings = bookings.Where(x => x.BookingId == roomid);
            if (hotelid != null)
                bookings = bookings.Where(x => x.Room.HotelId == hotelid);
            if (date != null)
                bookings = bookings.Where(x => x.BookingDate == date);
            foreach (Booking booking in bookings.ToList())
            {
                bookingvm.Add(Mapper.Map<Booking, BookingViewModel>(booking));
            }
            return bookingvm;
        }

        public bool UpdateBooking(BookingViewModel booking)
        {
            return bookingdl.UpdateBooking(Mapper.Map<BookingViewModel, Booking>(booking));
        }
    }
}

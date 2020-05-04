using HotelManagement_DL.Interface;
using HotelManagement_Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_DL.Services
{
    public class BookingDL : IBLBooking
    {
        private HotelManagementEntities db;

        public BookingDL()
        {
            db = new HotelManagementEntities();
        }
        public bool AddBooking(Booking booking)
        {
            try
            {
                db.Bookings.Add(booking);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteBooking(int id)
        {
            try
            {
                Booking mybooking = db.Bookings.Where(booking => booking.BookingId == id).FirstOrDefault();
                mybooking.BookingStatus = "Deleted";
                db.Entry(mybooking).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public IQueryable<Booking> GetAllBookings()
        {
            return db.Bookings.OrderBy(booking => booking.BookingDate);
        }

        public Booking GetBooking(int id)
        {
            return db.Bookings.Where(booking => booking.BookingId == id).Where(booking => booking.BookingStatus != "Deleted").FirstOrDefault();
        }

        public bool UpdateBooking(Booking booking)
        {
            try
            {
                db.Entry(booking).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

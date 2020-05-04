using HotelManagement_BL.Interface;
using HotelManagement_Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_DL.Services
{
    public class RoomDL : IBLRoom
    {
        private HotelManagementEntities db;
        public RoomDL()
        {
            db = new HotelManagementEntities();
        }

        public bool AddRoom(Room room)
        {
            try
            {
                db.Rooms.Add(room);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteRoom(int id)
        {
            try
            {
                db.Rooms.Remove(db.Rooms.Where(room => room.RoomId == id).FirstOrDefault());
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<Room> GetAllRooms()
        {
            return db.Rooms.OrderBy(room => room.RoomPrice);
        }

        public Room GetRoomById(int id)
        {
            return db.Rooms.Where(room => room.RoomId == id).FirstOrDefault();
        }

        public bool IsAvailable(int id)
        {
            int count = db.Bookings.Where(booking => booking.BookingId == id).Where(booking => booking.BookingStatus == "Cancelled").Where(booking => booking.BookingStatus == "Deleted").Count();
            return count > 0 ? true : false;
        }

        public bool UpdateRoom(Room room)
        {
            try
            {
                db.Entry(room).State = EntityState.Modified;
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

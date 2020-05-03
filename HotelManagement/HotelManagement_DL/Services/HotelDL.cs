using HotelManagement_DL.Interface;
using HotelManagement_Entities.ViewModel;
using System;
using System.Collections.Generic;
using HotelManagement_Entities.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_DL.Services
{
    public class HotelDL : IDLHotel
    {
        private HotelManagementEntities db;
        public HotelDL()
        {
            db = new HotelManagementEntities();
        }

        public bool AddHotel(Hotel hotel)
        {
            try
            {
                db.Hotels.Add(hotel);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteHotel(int id)
        {
            try
            {
                db.Hotels.Remove(db.Hotels.Where(hotel => hotel.HotelId == id).FirstOrDefault());
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Hotel> GetAllHotels()
        {
            return db.Hotels.OrderBy(hotel => hotel.HotelName).ToList();
        }

        public List<Hotel> GetHotelByCity(string city)
        {
            return db.Hotels.Where(hotel => hotel.HotelCity == city).ToList();
        }

        public Hotel GetHotelById(int id)
        {
            return db.Hotels.Where(hotel => hotel.HotelId == id).FirstOrDefault();
        }

        public List<Hotel> GetHotelByPincode(int pincode)
        {
            return db.Hotels.Where(hotel => hotel.HotelPinCode == pincode).ToList();
        }
    }
}

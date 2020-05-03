using HotelManagement_BL.Interface;
using HotelManagement_Entities.ViewModel;
using HotelManagement_Entities.Models;
using System;
using HotelManagement_DL.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_BL.Services
{
    public class HotelBL : IBLHotel
    {
        private HotelDL hoteldl;

        public HotelBL(HotelDL _hoteldl){
            hoteldl = _hoteldl;
        }

        public bool AddHotel(HotelViewModel hotel)
        {
            return hoteldl.AddHotel(Mapper.Map<HotelViewModel, Hotel>(hotel));
        }

        public bool DeleteHotel(int id)
        {
            return hoteldl.DeleteHotel(id);
        }

        public List<HotelViewModel> GetAllHotels()
        {
            List<Hotel> hoteldata = hoteldl.GetAllHotels();
            List<HotelViewModel> hotelvm = new List<HotelViewModel>();

            foreach (Hotel hotel in hoteldata)
            {
                hotelvm.Add(Mapper.Map<Hotel, HotelViewModel>(hotel));
            }

            return hotelvm;
        }

        public List<HotelViewModel> GetHotelByCity(string city)
        {
            List<Hotel> hoteldata = hoteldl.GetHotelByCity(city);
            List<HotelViewModel> hotelvm = new List<HotelViewModel>();
            
            foreach(Hotel hotel in hoteldata)
            {
                hotelvm.Add(Mapper.Map<Hotel, HotelViewModel>(hotel));
            }

            return hotelvm; 
        }

        public HotelViewModel GetHotelById(int id)
        {
            return Mapper.Map<Hotel, HotelViewModel>(hoteldl.GetHotelById(id));
        }

        public List<HotelViewModel> GetHotelByPincode(int pincode)
        {
            List<Hotel> hoteldata = hoteldl.GetHotelByPincode(pincode);
            List<HotelViewModel> hotelvm = new List<HotelViewModel>();

            foreach (Hotel hotel in hoteldata)
            {
                hotelvm.Add(Mapper.Map<Hotel, HotelViewModel>(hotel));
            }

            return hotelvm;
        }
    }
}

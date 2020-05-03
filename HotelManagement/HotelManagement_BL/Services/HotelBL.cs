using HotelManagement_BL.Interface;
using HotelManagement_Entities.ViewModel;
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

        public bool AddHotel()
        {
            throw new NotImplementedException();
        }

        public bool DeleteHotel(int id)
        {
            throw new NotImplementedException();
        }

        public List<HotelViewModel> GetAllHotels()
        {
            throw new NotImplementedException();
        }

        public List<HotelViewModel> GetHotelByCity(string city)
        {
            throw new NotImplementedException();
        }

        public HotelViewModel GetHotelById(int id)
        {
            throw new NotImplementedException();
        }

        public List<HotelViewModel> GetHotelByPincode(int pincode)
        {
            throw new NotImplementedException();
        }
    }
}

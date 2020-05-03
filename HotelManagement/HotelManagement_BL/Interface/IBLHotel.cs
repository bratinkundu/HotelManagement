using HotelManagement_Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_BL.Interface
{
    public interface IBLHotel
    {
        List<HotelViewModel> GetAllHotels();
        List<HotelViewModel> GetHotelByCity(string city);
        List<HotelViewModel> GetHotelByPincode(int pincode);
        HotelViewModel GetHotelById(int id);
        bool AddHotel();
        bool DeleteHotel(int id);
    }
}

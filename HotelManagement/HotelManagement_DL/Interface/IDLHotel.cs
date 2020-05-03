using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement_Entities.Models;
using HotelManagement_Entities.ViewModel;

namespace HotelManagement_DL.Interface
{
    public interface IDLHotel
    {
        List<Hotel> GetAllHotels();
        List<Hotel> GetHotelByCity(string city);
        List<Hotel> GetHotelByPincode(int pincode);
        Hotel GetHotelById(int id);
        bool AddHotel(Hotel hotel);
        bool DeleteHotel(int id);
    }
}

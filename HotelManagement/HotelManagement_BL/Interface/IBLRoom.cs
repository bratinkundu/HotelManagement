using HotelManagement_Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_BL.Interface
{
    public interface IBLRoom
    {
        List<RoomViewModel> GetAllRooms();
        RoomViewModel GetRoomById(int id);
        bool AddRoom(RoomViewModel room);
        bool UpdateRoom(RoomViewModel room);
        bool DeleteRoom(int id);
        bool IsAvailable(int id);
        List<RoomViewModel> GetAllRooms(string city, int? pincode, int? price, string category);
    }
}

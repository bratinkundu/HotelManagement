using HotelManagement_Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_BL.Interface
{
    public interface IBLRoom
    {
        IQueryable<Room> GetAllRooms();
        Room GetRoomById(int id);
        bool AddRoom(Room room);
        bool UpdateRoom(Room room);
        bool DeleteRoom(int id);
        bool IsAvailable(int id);
    }
}

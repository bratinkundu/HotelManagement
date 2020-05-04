using HotelManagement_BL.Interface;
using HotelManagement_DL.Interface;
using HotelManagement_DL.Services;
using HotelManagement_Entities.Models;
using HotelManagement_Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_BL.Services
{
    public class RoomBL : IBLRoom
    {
        private RoomDL roomdl;
        public RoomBL(RoomDL _roomdl)
        {
            roomdl = _roomdl;
        }
        public bool AddRoom(RoomViewModel room)
        {
            return roomdl.AddRoom(Mapper.Map<RoomViewModel, Room>(room));
        }

        public bool DeleteRoom(int id)
        {
            return roomdl.DeleteRoom(id);
        }

        public List<RoomViewModel> GetAllRooms()
        {
            List<Room> roomdata = roomdl.GetAllRooms().ToList();
            List<RoomViewModel> roomvm = new List<RoomViewModel>();

            foreach(Room room in roomdata)
            {
                roomvm.Add(Mapper.Map<Room, RoomViewModel>(room));
            }
            return roomvm;
        }

        public RoomViewModel GetRoomById(int id)
        {
            return Mapper.Map<Room, RoomViewModel>(roomdl.GetRoomById(id));
        }

        public List<RoomViewModel> GetAllRooms(string city, int? pincode, int? price, string category)
        {
            IQueryable<Room> roomdata = roomdl.GetAllRooms();
            List<RoomViewModel> roomvm = new List<RoomViewModel>();

            if (city != null)
                roomdata = roomdata.Where(hotel => hotel.Hotel.HotelCity == city);
            if (pincode != null)
                roomdata = roomdata.Where(hotel => hotel.Hotel.HotelPinCode == pincode);
            if (price != null)
                roomdata = roomdata.Where(room => room.RoomPrice == price);
            if (category != null)
                roomdata = roomdata.Where(room => room.RoomCategory == category);

            foreach (Room room in roomdata.ToList())
            {
                roomvm.Add(Mapper.Map<Room, RoomViewModel>(room));
            }
            return roomvm;
        }

        public bool IsAvailable(int id)
        {
            return roomdl.IsAvailable(id);
        }

        public bool UpdateRoom(RoomViewModel room)
        {
            return roomdl.UpdateRoom(Mapper.Map<RoomViewModel, Room>(room));
        }
    }
}

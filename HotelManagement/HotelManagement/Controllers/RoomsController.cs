using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using HotelManagement_BL.Interface;
using HotelManagement_BL.Services;
using HotelManagement_Entities.ViewModel;
using System.Web.Http;
using HotelManagement.App_Start;

namespace HotelManagement.Controllers
{
    [AuthFilter]
    public class RoomsController : ApiController
    {
        private RoomBL roombl;

        public RoomsController(RoomBL _roombl)
        {
            roombl = _roombl;
        }

        [HttpGet,Route("api/Room/")]
        public IHttpActionResult GetRooms()
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, roombl.GetAllRooms()));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpGet,Route("api/Room/{id}")]
        public IHttpActionResult GetRooms(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, roombl.GetRoomById(id)));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpGet,Route("api/Room/Search/")]
        public IHttpActionResult GetRooms(string city = null, int? pincode = null, int? price = null, string category = null)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, roombl.GetAllRooms(city, pincode, price, category)));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpPost, Route("api/Room/Add")]
        public IHttpActionResult AddRoom(RoomViewModel room)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, roombl.AddRoom(room)));
            }
            catch
            {
                return InternalServerError();
            }
        }
        [HttpPut, Route("api/Room/Update/")]
        public IHttpActionResult Put(RoomViewModel room)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, roombl.UpdateRoom(room)));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpGet, Route("api/Room/IsAvailable/{id}")]
        public IHttpActionResult GetAvailibility(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, roombl.IsAvailable(id)));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpDelete,Route("api/Room/Delete/{id}")]
        public IHttpActionResult DeleteRoom(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, roombl.DeleteRoom(id)));
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}

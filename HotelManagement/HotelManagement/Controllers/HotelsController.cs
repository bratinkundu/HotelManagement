using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HotelManagement_Entities.ViewModel;
using HotelManagement_BL.Interface;
using HotelManagement.App_Start;

namespace HotelManagement.Controllers
{
    [AuthFilter]
    public class HotelsController : ApiController
    {
        private IBLHotel hotelbl;

        public HotelsController(IBLHotel _hotelbl)
        {
            hotelbl = _hotelbl;
        }

        [HttpPost, Route("api/Hotel/Add/")]
        public IHttpActionResult AddHotel(HotelViewModel hotel)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, hotelbl.AddHotel(hotel)));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpGet, Route("api/Hotel/")]
        public IHttpActionResult GetHotels()
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, hotelbl.GetAllHotels()));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpGet, Route("api/Hotel/{id}")]
        public IHttpActionResult GetHotels(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, hotelbl.GetHotelById(id)));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpGet, Route("api/Hotel/{pincode}")]
        public IHttpActionResult GetHotelByPincode(int pincode)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, hotelbl.GetHotelByPincode(pincode)));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpGet, Route("api/Hotel/{city}")]
        public IHttpActionResult GetHotelByCity(string city)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, hotelbl.GetHotelByCity(city)));
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpDelete, Route("api/Hotel/Delete/{id}")]
        public IHttpActionResult DeleteHotel(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, hotelbl.DeleteHotel(id)));
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}

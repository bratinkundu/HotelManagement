using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HotelManagement_BL.Interface;
using HotelManagement_Entities.ViewModel;

namespace HotelManagement.Controllers
{
    public class BookingsController : ApiController
    {
        private IBLBooking bookingbl;
        public BookingsController(IBLBooking bLBooking)
        {
            bookingbl = bLBooking;
        }
        [HttpGet, Route("api/Booking")]
        public IHttpActionResult GetBookings()
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, bookingbl.GetBookings()));
            }
            catch
            {
                return InternalServerError();
            }
        }
        [HttpGet, Route("api/Booking/Search")]
        public IHttpActionResult GetBookings(Nullable<DateTime> date = null, int? roomid = null, int? hotelid = null)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, bookingbl.GetBookings(date,roomid,hotelid)));
            }
            catch
            {
                return InternalServerError();
            }
        }
        [HttpGet, Route("api/Booking/{id}")]
        public IHttpActionResult GetBooking(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, bookingbl.GetBooking(id)));
            }
            catch
            {
                return InternalServerError();
            }
        }
        [HttpPost, Route("api/Booking/Add")]
        public IHttpActionResult AddBooking(BookingViewModel booking)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, bookingbl.AddBooking(booking)));
            }
            catch
            {
                return InternalServerError();
            }
        }
        [HttpPut, Route("api/Booking/Update/")]
        public IHttpActionResult UpdateBooking(BookingViewModel booking)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, bookingbl.UpdateBooking(booking)));
            }
            catch
            {
                return InternalServerError();
            }
        }
        [HttpDelete, Route("api/Booking/Delete/{id}")]
        public IHttpActionResult DeleteBooking(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, bookingbl.DeleteBooking(id)));
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}

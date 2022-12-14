using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StoreAppPhase2.EntityModels;
using StoreAppPhase2.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreAppPhase2.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IDataReposity _IDataRepository;
        private readonly IMapper _mapper;

        public BookController(IDataReposity IdataReposity, IMapper mapper)
        {
            _IDataRepository = IdataReposity ??
                throw new ArgumentNullException(nameof(IdataReposity));
            _mapper = mapper;
        }

        [Route("InsertBooking")]
        [HttpPost()]
        public IActionResult PostBookingEMData(BookingServices bookingServices)
        {
            try{var BookingServiceEM = _IDataRepository.PostBookingEMData(bookingServices);return Ok(BookingServiceEM);}
            catch (Exception ex)
            { return Ok(ex.Message.ToString());}
        }



    }
}


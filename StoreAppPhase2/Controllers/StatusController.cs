using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;
using StoreAppPhase2.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreAppPhase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : Controller
    {
        private readonly IDataReposity _IDataRepository;
        private readonly IMapper _mapper;

        public StatusController(IDataReposity IdataReposity, IMapper mapper)
        {
            _IDataRepository = IdataReposity ??
                throw new ArgumentNullException(nameof(IdataReposity));
            _mapper = mapper;
        }

        [Route("InsertStatus")]
        [HttpPost()]
        public IActionResult PostStatusData(StatusItems statusItems)
        {

            var statusItem = _IDataRepository.PostStatusData(statusItems);
            return Ok(statusItem);

        }



    }
}


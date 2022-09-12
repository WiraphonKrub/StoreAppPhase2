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
        [Route("GetStatus")]
        [HttpGet()]
        public IActionResult GetStatusForsaleDatas()
        {
            try { var statusItem = _IDataRepository.GetStatusItems(); return Ok(statusItem); }
            catch (Exception ex)
            { return Ok(ex.Message.ToString()); }

        }
        [Route("InsertStatusForSale")]
        [HttpPost()]
        public IActionResult PostStatusForsaleData(StatusForSale statusForSale)
        {
            try{var statusItem = _IDataRepository.PostStatusForsaleData(statusForSale);return Ok(statusItem);}
            catch (Exception ex)
            {return Ok(ex.Message.ToString());}

        }
        [Route("InsertStatusItems")]
        [HttpPost()]
        public IActionResult PostStatusItemsData(StatusItems[] statusItems)
        {
          
            try {var statusItem = _IDataRepository.PostStatusData(statusItems);return Ok(statusItem);}
            catch(Exception ex)
            {return Ok(ex.Message.ToString());}

        }

        [Route("DeleteStatusItem")]
        [HttpDelete()]
        public IActionResult DeleteStatusItemData(StatusItems[] statusItems)
        {
            try{var statusItem = _IDataRepository.DeleteStatusData(statusItems);return Ok(statusItem);}
            catch (Exception ex)
            {return Ok(ex.Message.ToString());}

        }

    }
}


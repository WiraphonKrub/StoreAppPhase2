using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleEMController : ControllerBase
    {
        private readonly IDataReposity _IDataRepository;
        private readonly IMapper _mapper;

        public SaleEMController(IDataReposity IdataReposity, IMapper mapper)
        {
            _IDataRepository = IdataReposity ??
                throw new ArgumentNullException(nameof(IdataReposity));
            _mapper = mapper;
        }

        [Route("InsertSaleInvoices")]
        [HttpPost()]
        public IActionResult PostSaleInvoicesData(SaleInvoices saleInvoice)
        {

          try{var SaleEM = _IDataRepository.PostSaleInvoicesEMData(saleInvoice);return Ok(SaleEM);}
          catch (Exception ex)
          {return Ok(ex.Message.ToString());}
        }

        [Route("GetSaleInvoices")]
        [HttpGet()]
        public IActionResult GetSellingDatas()
        {
            try{var SaleEMs = _IDataRepository.GetSaleInvoicesEMDatas();return Ok(SaleEMs);}
            catch (Exception ex)
            { return Ok(ex.Message.ToString()); }
        }

        [Route("GetSaleInvoice")]
        [HttpGet()]
        public IActionResult GetSellingData(SaleInvoices saleInvoices)
        {
          try{var SaleEM = _IDataRepository.GetSaleInvoicesEMData(saleInvoices);return Ok(SaleEM);}
          catch (Exception ex)
          {return Ok(ex.Message.ToString());}

        }
        [Route("DeleteSaleInvoice")]
        [HttpDelete()]
        public IActionResult DeleteSellingData(SaleInvoices saleInvoices)
        {
            try{var SaleEM = _IDataRepository.DeleteSaleInvoicesEMData(saleInvoices);return Ok(SaleEM);}
            catch (Exception ex)
            {return Ok(ex.Message.ToString());}

        }
        [Route("UpdateSaleInvoice")]
        [HttpPut()]
        public IActionResult PutSellingData(SaleInvoices saleInvoice)
        {
            try { var SaleEM = _IDataRepository.PutSaleInvoicesEMData(saleInvoice); return Ok(SaleEM);}
            catch (Exception ex)
            { return Ok(ex.Message.ToString()); }
        }


    }

}


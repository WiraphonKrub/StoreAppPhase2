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
    public class SellingController : ControllerBase
    {
        private readonly IDataReposity _IDataRepository;
        private readonly IMapper _mapper;

        public SellingController(IDataReposity IdataReposity, IMapper mapper)
        {
            _IDataRepository = IdataReposity ??
                throw new ArgumentNullException(nameof(IdataReposity));
            _mapper = mapper;
        }

        [Route("InsertSelling")]
        [HttpPost()]
        public IActionResult PostSellingData(SaleInvoice saleInvoice)
        {
            
            var SellingEM = _IDataRepository.PostSellingEMData(saleInvoice.InvoiceNo, saleInvoice.IdEM, saleInvoice.StatusItemID);
            return Ok(SellingEM);

        }

        [Route("Getsellingall")]
        [HttpGet()]
        public IActionResult GetSellingDatas()
        {

            var SellingEMs = _IDataRepository.GetSellingEMDatas();
            return Ok(SellingEMs);

        }

        [Route("GetSelling")]
        [HttpGet()]
        public IActionResult GetSellingData(int SellingEMID)
        {
            var SellingEM = _IDataRepository.GetSellingEMData(SellingEMID);
            return Ok(SellingEM);

        }
        [Route("DeleteSelling")]
        [HttpDelete()]
        public IActionResult DeleteSellingData(int SellingEMID)
        {
            var SellingEM = _IDataRepository.DeleteSellingEMData(SellingEMID);
            return Ok(SellingEM);

        }
        [Route("UpdateSelling")]
        [HttpPut()]
        public IActionResult PutSellingData(SaleInvoice saleInvoice)
        {
            var SellingEM = _IDataRepository.PutSellingEMData(saleInvoice.SaleInvoiceID, saleInvoice.InvoiceNo, saleInvoice.IdEM, saleInvoice.StatusItemID);
            return Ok(SellingEM);

        }


    }

}


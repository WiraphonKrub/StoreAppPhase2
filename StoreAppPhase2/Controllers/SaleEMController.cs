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
            
            var SellingEM = _IDataRepository.PostSaleInvoicesEMData(saleInvoice);
            return Ok(SellingEM);

        }

        [Route("GetSaleInvoices")]
        [HttpGet()]
        public IActionResult GetSellingDatas()
        {

            var SellingEMs = _IDataRepository.GetSaleInvoicesEMDatas();
            return Ok(SellingEMs);

        }

        [Route("GetSaleInvoice")]
        [HttpGet()]
        public IActionResult GetSellingData(SaleInvoices saleInvoices)
        {
            var SellingEM = _IDataRepository.GetSaleInvoicesEMData(saleInvoices);
            return Ok(SellingEM);

        }
        [Route("DeleteSaleInvoice")]
        [HttpDelete()]
        public IActionResult DeleteSellingData(SaleInvoices saleInvoices)
        {
            var SellingEM = _IDataRepository.DeleteSaleInvoicesEMData(saleInvoices);
            return Ok(SellingEM);

        }
        [Route("UpdateSaleInvoice")]
        [HttpPut()]
        public IActionResult PutSellingData(SaleInvoices saleInvoice)
        {
            var SellingEM = _IDataRepository.PutSaleInvoicesEMData(saleInvoice);
            return Ok(SellingEM);

        }


    }

}


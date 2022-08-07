using System;
using StoreAppPhase2.Entities;
using StoreAppPhase2.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace StoreAppPhase2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IDataReposity _IDataRepository;
        private readonly IMapper _mapper;

        public DataController(IDataReposity IdataReposity, IMapper mapper)
        {
            _IDataRepository = IdataReposity ??
                throw new ArgumentNullException(nameof(IdataReposity));
            _mapper = mapper;
        }
        [Route("GetEmployees")]
        [HttpGet()]
        public IActionResult GetEmployees()
        {
            var employee = _IDataRepository.GetEmployees();
            return Ok(employee);

        }
    }

}


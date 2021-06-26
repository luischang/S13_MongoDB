using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S13_MongoDB.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S13_MongoDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("GetCustomer")]
        public async Task<IActionResult> GetCustomer()
        {
            var result = await _customerService.GetCustomers();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public async Task<IActionResult> GetCustomerById(string id)
        {
            var result = await _customerService.GetCustomerById(id);
            return Ok(result);
        }


    }
}

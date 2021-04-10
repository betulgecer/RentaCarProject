using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarsController : ControllerBase
    {

        IRentACarService _rentACarService;
        IPaymentService _paymentService;

        public RentACarsController(IRentACarService rentACarService, IPaymentService paymentService)
        {
            _rentACarService = rentACarService;
            _paymentService = paymentService;
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rentACar) 
        {
            var result = _rentACarService.Insert(rentACar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("delete")]
        public IActionResult Delete(Rental rentACar)
        {
            var result = _rentACarService.Delete(rentACar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Rental rentACar)
        {
            var result = _rentACarService.Update(rentACar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentACarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int rentalId)
        {
            var result = _rentACarService.GetById(rentalId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentaldetails")]
        public IActionResult GetRentalDetail()
        {
            var result = _rentACarService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("payment")]
        public IActionResult PaymentTest(PaymentTest amount)
        {
            var result = _paymentService.MakePayment(amount);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);

        }

        [HttpGet("getrentaldetailsbyid")]
        public IActionResult GetRentalDetailsById(int id)
        {

            var result = _rentACarService.GetRentalDetailById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}

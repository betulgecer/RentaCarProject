using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        //for test

        [HttpGet("payment")]
        public IActionResult MakePayment(PaymentTest payment)
        {
            var result = _paymentService.MakePayment(payment);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}

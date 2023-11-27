using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RefundManagementApp.BusinessLayer.Interfaces;
using RefundManagementApp.BusinessLayer.ViewModels;
using RefundManagementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefundManagementApp.Controllers
{
    [ApiController]
    public class RefundManagementController : ControllerBase
    {
        private readonly IRefundManagementService  _refundService;
        public RefundManagementController(IRefundManagementService refundservice)
        {
             _refundService = refundservice;
        }

        [HttpPost]
        [Route("create-refund")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateRefund([FromBody] Refund model)
        {
            //write your code here
            throw new NotImplementedException();

        }


        [HttpPut]
        [Route("update-refund")]
        public async Task<IActionResult> UpdateRefund([FromBody] RefundViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        [HttpDelete]
        [Route("delete-refund")]
        public async Task<IActionResult> DeleteRefund(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-refund-by-id")]
        public async Task<IActionResult> GetRefundById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-refunds")]
        public async Task<IEnumerable<Refund>> GetAllRefunds()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}

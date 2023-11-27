using RefundManagementApp.BusinessLayer.Interfaces;
using RefundManagementApp.BusinessLayer.Services.Repository;
using RefundManagementApp.BusinessLayer.ViewModels;
using RefundManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RefundManagementApp.BusinessLayer.Services
{
    public class RefundManagementService : IRefundManagementService
    {
        private readonly IRefundManagementRepository _repo;

        public RefundManagementService(IRefundManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Refund> CreateRefund(Refund employeeRefund)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteRefundById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Refund> GetAllRefunds()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Refund> GetRefundById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Refund> UpdateRefund(RefundViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}

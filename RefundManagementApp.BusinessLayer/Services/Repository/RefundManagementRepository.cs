using Microsoft.EntityFrameworkCore;
using RefundManagementApp.BusinessLayer.ViewModels;
using RefundManagementApp.DataLayer;
using RefundManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RefundManagementApp.BusinessLayer.Services.Repository
{
    public class RefundManagementRepository : IRefundManagementRepository
    {
        private readonly RefundManagementAppDbContext _dbContext;
        public RefundManagementRepository(RefundManagementAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Refund> CreateRefund(Refund RefundModel)
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
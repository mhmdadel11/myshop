﻿using myshop.Entities.Models;
using myshop.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myshop.DataAccess.Implementation
{
    public class OrderHeaderRepository : GenericRepository<OrderHeader>,IOrderHeaderRepository
    {
        private ApplicationDbContext _context;
        public OrderHeaderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(OrderHeader orderHeader)
        {
            _context.OrderHeaders.Update(orderHeader);
        }


		public void UpdateOrderStatus(int id, string OrderStatus, string Paymentstatus)
		{
            var orderfromDB = _context.OrderHeaders.FirstOrDefault(x => x.Id == id);
            if(orderfromDB != null)
            {
                orderfromDB.OrderStatus = OrderStatus;
                orderfromDB.PaymentDate = DateTime.Now;
                if(Paymentstatus != null)
                {
                    orderfromDB.PaymentStatus = Paymentstatus;
                }
            }
		}

        public void UpdateStatus(int id, string? OrderStatus, string? PaymentStatus)
        {
            throw new NotImplementedException();
        }
    }
}

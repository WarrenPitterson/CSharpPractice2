﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class OrderRepository
    {
       public Order Retrieve(int orderId)
        { 
            Order order = new Order(orderId);

            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 5, 20, 16, 30, 00, new TimeSpan(7, 0, 0));
            }
       
        return order;
    }

    bool Save(Order order)
    {
        return true;
    }
}
}
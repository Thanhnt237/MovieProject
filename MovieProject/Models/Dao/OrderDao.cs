﻿using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class OrderDao
    {
        MovieProjectDbcontext db = null;

        public OrderDao()
        {
           db = new MovieProjectDbcontext();
        }
        public long Insert(Order order)
        {
            db.OrdersDetail.Add(order);
            db.SaveChanges();
            return order.ID;
        }

    }
}

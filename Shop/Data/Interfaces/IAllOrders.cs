﻿using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
   public interface IAllOrders
    {
        void CreateOrder(Order order);
    }
}

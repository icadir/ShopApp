﻿using ShopApp.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
    public interface ICartDal : IRepository<Cart>
    {
        Cart GetByUserId(string userId);
    }
}

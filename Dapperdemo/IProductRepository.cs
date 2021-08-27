﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dapperdemo
{
    public interface IProductRepository
    {
       public IEnumerable<Product> GetAllProducts();
        void CreateProduct(string name, double price, int categoryID);
    }
}

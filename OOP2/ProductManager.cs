﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void Update(Product product2)
        {
            Console.WriteLine(product2.ProductName + " Güncellendi.");

        }
        



    }
}

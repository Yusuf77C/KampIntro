﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
       
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi :" + product.Pname + ", Fiyat :"+ product.Price + ", Açıklama :" + product.Exp);
        }

    }
}

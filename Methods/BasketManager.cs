using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Sepete Eklendi"+ " Ürün Adı :"+product.ProductName+ " Fiyatı :"+product.ProductPrice+" tl'dir");
        }
       
    }
}

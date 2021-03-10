using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.ProductDetails = "Amasya Elması Çok Lezzetlidir";
            product1.ProductPrice = 15;
            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.ProductDetails = "Diyarbakır Karpuzu Çok Lezzetlidir";
            product2.ProductPrice = 55;

            Product[] products = new Product[] { product1, product2 };
            //type-safe => Tip Güvenliği
            //foreach (Product product in products)
            //{
                //Console.WriteLine(product.ProductName+" "+product.ProductDetails+" "+product.ProductPrice+" tl'dir");
            //}
            //Instance => Örnek
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
        }
    }
}

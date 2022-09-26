using kampOdevi;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.Name = "Mont";
        product1.Price = 495.98;

        Product product2 = new Product();
        product2.Id = 2;
        product2.Name = "Sweatshirt";
        product2.Price = 259.99;

        Product product3 = new Product();
        product3.Id = 3;
        product3.Name = "T shirt";
        product3.Price = 109.95;

        Product[] products = new Product[] { product1, product2, product3 };

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine("ID:" + products[i].Id + " " + "Ürünün Adı:" + products[i].Name + " " + "Fiyatı:" + products[i].Price);
        }
        Console.WriteLine(" ");
        foreach (var product in products)
        {
            Console.WriteLine("ID:" + product.Id + " " + "Ürünün Adı:" + product.Name + " " + "Fiyatı " + product.Price);
        }
        Console.WriteLine(" ");
        int a = 0;
        while (a <3)
        {
            Console.WriteLine("ID:" + products[a].Id + " " + "Ürünün Adı:" + products[a].Name + " " + "Fiyatı " + products[a].Price);
            a++;
            
        }
    }
}
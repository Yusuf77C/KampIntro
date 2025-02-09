namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dont repeat yourself - clean code 
            //Pascal case (Kelimelerin ilk harflerinin büyük yazılması)

            Product product1 = new Product();

            product1.Pname = "Apple";
            product1.Price = 15;
            product1.Exp = "Red apple";



            Product product2 = new Product();

            product2.Pname = "Lemon";
            product2.Price = 10;
            product2.Exp = "Green lemon";

            //Product Arry
            Product[] products = new Product[] {product1 , product2};

            foreach (Product item in products)
            {
                Console.WriteLine(item.Pname);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Exp);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("--------------Methods---------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Add(product1);
            sepetManager.Add(product2);
            

        }
    }
}

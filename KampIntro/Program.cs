namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type saftey
            string isim = "Yusuf";
            Console.WriteLine(isim);

            // Do note repeat yourself (tekrarı azaltma) 



            bool kontrol1 = true;

            if (kontrol1 == true) 
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Login failed:/");
            }


            //example

            double UsdNow = 36.33;
            double UsdPast = 36.12;

            if (UsdPast>UsdNow)
            {
                Console.WriteLine("Dropped");
            }
            else if (UsdPast < UsdNow)
            {
                Console.WriteLine("Rise");
            }
            else
            {
                Console.WriteLine("Rmain Stable");
            }




        }
    }
}

namespace DegerVeReferansTip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değer (int , decimal , double , bool ... ) --> stack
            int A = 10;
            int B = 30;

            A = B;
            B = 65;
            // A =?
            Console.WriteLine(A);

            Console.WriteLine("------------------------");

            //Referans (Arrays , class , interface) ---> stack "new()" ---> heap
            int[] Array = new int[] {10, 20 , 30};

            int[] Array1 = new int[] { 100, 200, 300};

            Array = Array1;

            Array1[0] = 999;
            //Array[0] = ?

            Console.WriteLine(Array[0]);


        }
    }
}

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Hello World");
            }

            //Arrays

            string[] lesson = new string[] {"C#" , "python" , "java" , "C++"};


            for(int i= 0; i < lesson.Length; i++)
            {
                Console.WriteLine(lesson[i]);
            }

            //foreach

            int[] Numbers = new int[5];

            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;
            Numbers[3] = 4;
            Numbers[4] = 5;

            foreach (int num in Numbers)
            {
                Console.WriteLine(num);
            }



        }
    }
}

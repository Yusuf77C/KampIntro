using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string CoursName = "C#";
            string instructor = "Yusuf";
            int id = 12345678;


            // Object oluşturma ve değer atama
            MyClass myClass = new MyClass();
            myClass.CourseName = CoursName;
            myClass.instructor = instructor;
            myClass.id = id;



            // Burada myClass1 nesnesine değer ataması eksikti, düzelttik
            MyClass myClass1 = new MyClass();
            myClass1.CourseName = "Java";
            myClass1.instructor = "Omer";
            myClass1.id = 2222222;



            // Burada myClass2 nesnesine değer ataması eksikti, düzelttik
            MyClass myClass2 = new MyClass();
            myClass2.CourseName = "Python";
            myClass2.instructor = "Mehmet";
            myClass2.id = 33333333;



            // Nesneleri bir diziye atıyoruz
            MyClass[] myClasses = new MyClass[] { myClass, myClass1, myClass2 };



            // foreach ile ekrana yazdırma işlemi
            foreach (var cours in myClasses)
            {
                Console.WriteLine(cours.CourseName + " " + cours.instructor + " " + cours.id);
            }


        }
    }

    class MyClass
    {
        public string CourseName { get; set; }
        public string instructor { get; set; }
        public int id { get; set; }
    }
}

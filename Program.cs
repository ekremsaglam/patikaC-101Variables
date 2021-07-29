using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            value=5;
            string name="Ekrem";
            
            byte b =5;//1 byte
            sbyte c = 5;// 1 byte

            short s =5;//2 byte 
            ushort us = 5;//2 byte
            Int16 a = 2; // 2 byte
            int i = 2;//4 byte
            Int32 d = 2; // 4 byte
            Int64 e = 2; //8 byte

            long l = 4; //8 byte

            float f = 5; //4 byte
            double g = 5; //8 byte
            decimal de = 5; //16 byte
            
            char ch = 'a';//2 byte
            string str = "Ekrem"; // sınırsız

            bool b1= true;
            bool b2= false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt); 

            object o1 = "x";
            object o2 = '5';
            object o3 = 4;
            object o4 = 4.3;
            object o5 = true;
            
            
            string str1 = string.Empty;

            int integer1 = 5;
            int integer2 = 4;
            int integer3 = integer1*integer2;

            bool b3 = 10>4;//sonuç doğru ise b3 e 

            string str20 ="20";
            int int20 = 20;

            string newValue = str20+int20.ToString();
            
            int int21= int20+ Convert.ToInt32(str20);

            int int22 = int20+ int.Parse(str20);

            Console.WriteLine(str1);

            string datetime = DateTime.Now.ToString("dd,mm,yyyy");
            Console.WriteLine(datetime);
        }
    }
}

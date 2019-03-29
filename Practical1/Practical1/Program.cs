using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Practical1
    {
        static int j = 100;
        static int k = 90;
        public enum TimeOfDay
        {
            Morning = 0,
            Afternoon = 1,
            Evening = 2
        }
        static void Main(string[] args)
        {
            Console.WriteLine("My First Practical!!");
            Console.WriteLine("1....");
            // int i = 10;
            int j;

            for ( /*int*/j = 1; j < 3; j++)
            {
                //int j;
                Console.WriteLine("{0} {1}\n", j, Practical1.j);
            }
            Console.WriteLine("2....\n");
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("{0} {1}\n", k, Practical1.k);
            }//Scope of k ends here!!!
            //Console.WriteLine(k);
            Console.WriteLine("\nConstants!!");
            const int const_value = 50;
            Console.WriteLine("{0} is contant value!!", const_value);
            //const_value = 12;
            const int const_value2 = const_value + 8 /* + j*/;
            Console.WriteLine("Next Constant: {0}", const_value2);
            Console.WriteLine("Predefined Datatypes!!\n\nValue types and Referenced Types!!");
            Console.WriteLine("VALUE TYPES\n!!!");
            int val_a = 2, val_b = val_a;
            Console.WriteLine("val_a is: {0} and val_b is: {1}", val_a, val_b);
            val_b = 90;
            Console.WriteLine("val_a is: {0} and val_b is: {1}", val_a, val_b);
            Console.WriteLine("REFERENCE TYPES\n!!!");
            Vector a, b;
            a = new Vector();
            a.value = 5;
            b = a;
            Console.WriteLine("a:{0} and b:{1}", a.value, b.value);
            b.value = 33;
            Console.WriteLine("a:{0} and b:{1}", a.value, b.value);
            b = null;
            //Console.WriteLine("Value for b is:" +b.value);
            Console.WriteLine("INTEGER TYPES!!!");
            sbyte sb1 = 11;
            short s1 = 11;
            int s = 11;
            long s2 = 11L;
            Console.WriteLine("Unsigned Integers!!");
            byte b1 = 12;
            ushort b2 = 12;
            uint ub = 12;
            ulong ul = 12;
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", sb1, s1, s, s2, b1, b2, ub, ul);
            Console.WriteLine("FLoating Points!!");
            float f = 13.23412456F;
            double d = 1567.1345678933;
            Console.WriteLine("Float:{0} \n Double:{1}", f, d);
            Console.WriteLine("Decimal Type!!");
            decimal d1 = 1234.12345678123456780M;
            Console.WriteLine("Decimal:\n{0}", d1);
            Console.WriteLine("\nBOOLEAN!!!");
            bool valBoolean = true;
            Console.WriteLine("Status: " + valBoolean);
            Console.WriteLine("\nCharacter:\nSingle Quote \'");
            Console.WriteLine("Double Quote \"");
            Console.WriteLine("Back Slash \\");
            char charA = 'R';
            Console.WriteLine(charA);
            charA = '\0';
            Console.WriteLine("Now Null: " + charA);
            //Console.WriteLine("\a"); //Notofication Sound
            //Thread.Sleep(500);
            //Console.Beep(); //notification sound
            Console.WriteLine("\nPredefined Reference Types!!!");
            object o1 = "Hi, I am Richa Shah";
            object o2 = 51;
            string strObj = o1 as string;
            Console.WriteLine(strObj);
            Console.WriteLine(o1.GetHashCode() + " " + o1.GetType());
            Console.WriteLine(o2.GetHashCode() + " " + o2.GetType());
            Console.WriteLine(o1.Equals(o2));
            Console.WriteLine("\nSTRING!!!");
            string str1, str2;
            str1 = "Richa";
            str2 = str1;
            Console.WriteLine("S1 is: {0} and S2 is {1}", str1, str2);
            str2 = "Shah";
            Console.WriteLine("S1 is: {0} and S2 is {1}", str1, str2);
            str1 = "C:\\NewFolder\\Hello\\P1.cs";
            Console.WriteLine(str1);
            str1 = @"c:\NewFolder\Hello\P1.cs";
            Console.WriteLine(str1);
            str1 = @"We can also write 
like this";
            Console.WriteLine(str1);

            //Flow Control
            Console.WriteLine("\nThe if Statement!!");
            bool isZero;
            int i = 0;
            Console.WriteLine("\nFlow Control: (if)\ni is " + i);
            if (i == 0)
            {
                isZero = true;
                Console.WriteLine("i is Zero");
            }
            else
            {
                isZero = false;
                Console.WriteLine("i is Non - zero");
            }
            //Switch
            int integerA = 2;
            Console.WriteLine("\nSwitch!!!");
            switch (integerA)
            {
                case 1:
                    Console.WriteLine("integerA = 1");
                    break;
                case 2:
                    Console.WriteLine("integerA = 2");
                    //goto case 3;
                    break;
                case 3:
                    Console.WriteLine("integerA = 3");
                    break;
                default:
                    Console.WriteLine("integerA is not 1, 2, or 3");
                    break;
            }
            WriteGreeting(TimeOfDay.Morning);
            Console.WriteLine("Argument is: {0}", args[1]);
            Console.ReadLine();
        }
        
        static void WriteGreeting(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    Console.WriteLine("Good morning!");
                    break;
                case TimeOfDay.Afternoon:
                    Console.WriteLine("Good afternoon!");
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine("Good evening!");
                    break;
                default:
                    Console.WriteLine("Hello!");
                    break;
            }
        }

    }

    public class Vector
    {
        public int value;
    }
}



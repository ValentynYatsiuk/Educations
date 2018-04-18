using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Interface
{  
    interface IXYZ
    {
        void InputX();
        void InputA();
        void InputT();
        void Rezult();
       
    }

    class LineX : IXYZ
    {
        private double x0;
        private double a1;
        private double t;

        public LineX()
        {
            x0 = 0;
            a1 = 0;
             t = 0;
        }

        ~LineX()
        {
            Console.WriteLine("Destructor LineX!");

        }


        public void InputX()
        {
            
            Console.WriteLine("\nInput variable: x0 ");
            x0 = Convert.ToDouble(Console.ReadLine());

        }
        public void InputA()
        {
            Console.WriteLine("\nInput variable: a1 ");
            a1 = Convert.ToDouble(Console.ReadLine());
        }
        public void InputT()
        {
            Console.WriteLine("\nInput variable: t ");
            t = Convert.ToDouble(Console.ReadLine());
        }
        public void Rezult()
        {
            double x;
            x = x0 + a1 * Math.Sin(t);
            Console.WriteLine("\n\n a1=" + a1 + "\n Значення рухомої матерiальної точки x = " + x);
        }
        
        
    }
    class LineXYZ:IXYZ
    {
        private double a1;
        private double a2;
        private double a3;      
        private double x0;
        private double y0;
        private double z0;
        private double t;

        public LineXYZ()
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
            x0 = 0;
            y0 = 0;
            z0 = 0;
            t = 0;
        }
        ~LineXYZ()
        {
            Console.WriteLine("Destructor LineXYZ!");

        }
        public void InputX()
        {
            Console.WriteLine("\nInput variable: x0 ");
            x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput variable: y0 ");
            y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput variable: z0 ");
            z0 = Convert.ToDouble(Console.ReadLine());
        }
        public void InputA()
        {
            Console.WriteLine("Input variables a1 ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput variable: a2 ");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput variable: a3 ");
            a3 = Convert.ToDouble(Console.ReadLine());
        }
        public void InputT()
        {
            Console.WriteLine("\nInput variable: t ");
            t = Convert.ToDouble(Console.ReadLine());
        }
        public void Rezult()
        {
            double x, y, z;
            x = x0 + a1 * Math.Sin(t);
            y= y0 + a2 * Math.Cos(t); 
            z= z0 + a3 * Math.Pow(t, 2);
            Console.WriteLine("\n a1 = " + a1 + "\n a2 = " + a2 + "\n a3 = " + a3
                + "\nЗначення рухомої матерiальної точки x=" + x + "\nЗначення рухомої матерiальної точки y=" + y
                + "\nЗначення рухомої матерiальної точки z=" + z);
        }       
    }
    class Program
    {
        static void Main()
        {
            
            LineX x = new LineX();
            x.InputA();
            x.InputX();
            x.InputT();
            x.Rezult();

            LineXYZ xyz = new LineXYZ();
            xyz.InputA();
            xyz.InputX();
            xyz.InputT();
            xyz.Rezult();


            Console.ReadKey();
        }
    }
}

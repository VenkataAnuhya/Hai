//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Delegates
//{
//    public delegate void Rectdelegate(double h, double w);
//    class MulticastDelegate
//    {
//        public void RectArea(double height, double width)
//        {
//            double area = height * width;
//            Console.WriteLine("area of rectangle:" + area);

//        }
//        public static void RectPerimeter(double height, double width)
//        {
//            double perimeter = 2 * (height + width);
//            Console.WriteLine("perimeter of rectangle:" + perimeter);
//        }

//        public static void Main(String[] args)
//        {
//            MulticastDelegate md = new MulticastDelegate();
//            Rectdelegate rd = new Rectdelegate(md.RectArea);
//            rd += MulticastDelegate.RectPerimeter;
//            rd(25.2, 33.2);
//            Console.ReadLine();

//        }
//    }
//}

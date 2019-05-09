//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Genericcollections
//{
//    class Student : IComparable<Student>
//    {

//        public int sid { get; set; }
//        public string sname { get; set; }
//        public double marks { get; set; }

//        public int CompareTo(Student other)//we write anything we want in the place of other like o,a,f,etc...
//        {
//            if (this.sid > other.sid)
//                return 1;
//            else if (this.sid < other.sid)
//                return -1;
//            else
//                return 0;
//        }
//    }

//    /*To compare marks and this code is written some other one then we need to Icomparer Interface instead overwriting the method so we will not disturb the code*/
//    class CompareMarks : IComparer<Student>
//    {
//        public int Compare(Student x, Student y)
//        {
//            if (x.marks > y.marks)
//                return 1;
//            else if (x.marks < y.marks)
//                return -1;
//            else
//                return 0;
//        }
//    }
//    class TestStudent
//    {
//      /*  public static int CompareNames(Student x1, Student x2)
//        {
//            return x1.sname.CompareTo(x2.sname);

//        }*/
//        public static void Main(String[] args)
//        {
//            Student s1 = new Student() { sid = 1, sname = "anuhya" ,marks=72};
//            Student s2 = new Student() { sid = 2, sname = "amulya", marks=62};
//            Student s3 = new Student() { sid = 4, sname = "krishnapriya",marks=82 };
//            Student s4 = new Student() { sid = 3, sname = "sanjana",marks=52};
//            List<Student> students = new List<Student>() { s1, s2, s3, s4 };
//            students.Sort();
//          //  students.Reverse();
//            CompareMarks cm = new CompareMarks();
//            students.Sort(cm);

//       /*     //method 1 --in comparing strings
//            Comparison<Student> c = new Comparison<Student>(CompareNames);
//            students.Sort(c);*/

//               //method 2 --passing method name directly where the delegate is binded internally during compilation
//              //  students.Sort(CompareNames);

//                //method 3 --delegate anonymous method
//             //   students.Sort(delegate (Student p, Student q) { return p.sname.CompareTo(q.sname); });

//                //method 4 --lambda expressions
//                students.Sort((e,f)=>e.sname.CompareTo(f.sname));  

//            foreach (Student s in students)
//            {
//                Console.WriteLine("Student_Id : " + s.sid + '\t' + "Student_Name : " + s.sname+'\t'+"Student_Marks : "+s.marks);
//            }
//            Console.ReadLine();
//        }
//    }
//}
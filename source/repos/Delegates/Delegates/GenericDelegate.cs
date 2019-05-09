
//program which includes generic delegates along with the lambda expression n anonymous method


using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public double percentage { get; set; }
    }
    class GenericDelegate
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student() { id = 1, name = "anuhya", percentage = 74.6 };
            Student s2 = new Student() { id = 2, name = "amulya", percentage = 84.6 };
            Student s3 = new Student() { id = 4, name = "krishnaPriya", percentage = 94.6 };
            Student s4 = new Student() { id = 3, name = "Sanjana", percentage = 100 };
            List<Student> list = new List<Student>() { s1, s2, s3, s4 };

            /*Action<> delegate*/

            Action<Student, Student, Student, Student> distinction = (s5, s6, s7, s8) =>
                {
                    foreach (Student s in list)
                    {
                        if (s.percentage >= 90)
                        {
                            Console.WriteLine("\nthe students with percentage of above 90% is : " + s.name + " ----->  Topper");
                        }
                        else
                        {
                            Console.WriteLine("\nthe students with percentage of below 90% is : " + s.name + " ----->  pass");
                        }
                    }
                };
            distinction(s1, s2, s3, s4);

            /*Func<> delegate*/

            Func<Student, Student, Student, Student, string> highest = (h1, h2, h3, h4) =>
             {

                 if ((h1.percentage > h2.percentage) && (h1.percentage > h3.percentage) && (h1.percentage > h4.percentage))
                 {
                     return h1.name;
                 }
                 else if ((h2.percentage > h1.percentage) && (h2.percentage > h3.percentage) && (h2.percentage > h4.percentage))
                 {
                     return h2.name;
                 }
                 else if ((h3.percentage > h1.percentage) && (h3.percentage > h2.percentage) && (h3.percentage > h4.percentage))
                 {
                     return h3.name;
                 }
                 else
                     return h4.name;
             };

            string sname = highest(s1, s2, s3, s4);
            Console.WriteLine("\nThe topper of the Batch is: " + sname);

            /*predicate<> delegate*/

            Predicate<string> check = name =>
            {
                if (string.Compare(name, sname, true) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            bool value = check("anuhya");
            Console.WriteLine('\n' + sname + "  is topper: " + value);

            Console.ReadLine();

        }
    }
}

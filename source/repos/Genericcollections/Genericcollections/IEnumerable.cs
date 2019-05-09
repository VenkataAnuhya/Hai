using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Genericcollections
{
    class IEnumerable
    {

    }
    class Student
    {

        public int sid { get; set; }
        public string sname { get; set; }
        public double marks { get; set; }
    }
    public class organization : IEnumerable<Student>
    {
        public IEnumerator<Student> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public static void Main(String[] args)
    {
        Student s1 = new Student() { sid = 1, sname = "anuhya", marks = 72 };
        Student s2 = new Student() { sid = 2, sname = "amulya", marks = 62 };
        Student s3 = new Student() { sid = 4, sname = "krishnapriya", marks = 82 };
        Student s4 = new Student() { sid = 3, sname = "sanjana", marks = 52 };
       List<Student> students = new List<Student>() { s1, s2, s3, s4 };
        foreach (Student s in students)
        {
            Console.WriteLine("Student_Id : " + s.sid + '\t' + "Student_Name : " + s.sname + '\t' + "Student_Marks : " + s.marks);
        }
        Console.ReadLine();
    }
}


using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Name = "Karthik", Marks = 90 };
            Student s2 = new Student() { Name = "Rahul", Marks = 60 };
            Student s3 = new Student() { Name = "Karthik", Marks = 70 };
            Student s4 = new Student() { Name = "Aditya", Marks = 100 };
            ArrayList arrStudent = new ArrayList();
            arrStudent.Add(s1);
            arrStudent.Add(s2);
            arrStudent.Add(s3);
            arrStudent.Add(s4);
            Console.WriteLine("Student1 equals Student2: {0}", s1.Equals(s2));
            Console.WriteLine("Student1 equals Student3: {0}", s1.Equals(s3));
            Console.ReadLine();
        }
    }
    public class Student:IEquatable<Student>
    {
        public String Name { get; set; }
        public int Marks { get; set; }

        public bool Equals(Student other)
        {
            if (other == null) 
                return false;
            return (this.Name.Equals(other.Name));
        }
    }
}

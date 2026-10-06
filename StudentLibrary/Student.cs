using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLibrary
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        private static int studentCount = 0;

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
        }

        public Student()
        {
            this.id = studentCount++;
            this.name = "John Doe";
            this.age = 16;
        }

        public Student(string name, int age)
        {
            this.id = studentCount++;
            this.name = name;
            this.age = age;
        }

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            studentCount++;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }

        public int GetOlder()
        {
            this.age++;
            return this.age;
        }

        }
}

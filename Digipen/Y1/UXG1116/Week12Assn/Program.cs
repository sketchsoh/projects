using System;
using System.Collections.Generic;

partial class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("=== Testing Student ===");
            Student student1 = new Student("Gerald", "12345");
            Student student2 = new Student("Jeffrey", "24689");
          
            Console.WriteLine("Student #1's name: {0}", student1.GetName());
            Console.WriteLine("Student #2's name: {0}", student2.GetName());
            Console.WriteLine("Student #1's ID: {0}", student1.GetID());
            Console.WriteLine("Student #2's ID: {0}", student2.GetID());
          
            Console.Write("Printing Student #1 Info: ");
            student1.Print();
          
            Console.Write("Printing Student #2 Info: ");
            student2.Print();
        } 
          
        {
            Console.WriteLine("=== Testing Teacher ===");
            Teacher teacher1 = new Teacher("Gerald", "0102030", "Lecturer", 100);
            Teacher teacher2 = new Teacher("Prasanna", "5010203", "Provost", 1000);
            
            Console.WriteLine("Teacher #1's name: {0}", teacher1.GetName());
            Console.WriteLine("Teacher #2's name: {0}", teacher2.GetName());
            
            Console.Write("Printing Teacher #1 Info: ");
            teacher1.Print();
            
            Console.Write("Printing Teacher #2 Info: ");
            teacher2.Print();
        } 
          
        {
            Console.WriteLine("=== Testing Modules ===");
            Module m1 = new Module("Introduction to Programming", "UXG1116");
            Module m2 = new Module("Introduction to Math", "UXG1117");
            Module m3 = new Module("Introduction to Copium No Cap", "UXG1118");
            
            Student s1 = new Student("Gerald", "12345");
            Student s2 = new Student("Jeffrey", "24689");
            Student s3 = new Student("Pamela", "12034");
            Student s4 = new Student("Azim", "12030");
            Student s5 = new Student("Kefka", "02031");
            
            Teacher t1 = new Teacher("Gerald Wong", "0102030", "Lecturer", 1000);
            Teacher t2 = new Teacher("Jing Ying", "6120312", "Lecturer", 2000);
            
            m1.RegisterStudent(s1);
            m1.RegisterStudent(s2);
            m1.RegisterStudent(s3);
            m1.RegisterStudent(s4);
            m1.RegisterStudent(s5);
            m1.AssignLead(t1);
            
            m2.RegisterStudent(s1);
            m2.RegisterStudent(s2);
            m2.RegisterStudent(s3);
            m2.RegisterStudent(s5);
            m2.AssignLead(t2);
            
            m3.RegisterStudent(s1);
            m3.RegisterStudent(s2);
            
            Console.WriteLine("Printing Module #1 Info: ");
            m1.Print();
            Console.WriteLine();
            
            Console.WriteLine("Printing Module #2 Info: ");
            m2.Print();
            Console.WriteLine();
            
            Console.WriteLine("Printing Module #3 Info: ");
            m3.Print();
            Console.WriteLine();
          
        }       
    }
}


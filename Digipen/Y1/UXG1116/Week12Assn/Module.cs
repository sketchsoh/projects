using System;
using System.Collections.Generic;

class Module
{
    private string name;
    private string id;
    private List<Student> students;
    private Teacher moduleLead;

    public Module(string _name, string _id)
    {
        name = _name;
        id = _id;
        students = new List<Student>();
        moduleLead = null;
    }

    public void RegisterStudent(Student _student)
    {
        students.Add(_student);
    }

    public void AssignLead(Teacher _teacher)
    {
        moduleLead = _teacher;
    }

    public void Print()
    {
        Console.WriteLine("{0} - {1}", id, name);
        Console.WriteLine("Lead: {0}", moduleLead == null ? "Pending" : moduleLead.GetName());
        Console.WriteLine("Students:");
        foreach (Student _student in students)
        {
            Console.Write("> ");
            _student.Print();
        }
    }
}

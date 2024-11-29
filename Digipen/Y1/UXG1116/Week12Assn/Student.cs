using System;

class Student
{
    private string name;
    private string id;

    public Student(string _name, string _id)
    {
        this.name = _name;
        this.id = _id;
    }

    public string GetID()
    {
        return this.id;
    }

    public string GetName()
    {
        return this.name;
    }

    public void Print()
    {
        Console.WriteLine("{0} - {1}", id, name);
    }
}

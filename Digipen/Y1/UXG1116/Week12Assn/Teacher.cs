using System;


class Teacher
{
    private string name;
    private string id;
    private string title;
    private int salary;

    public Teacher(string name, string id, string title, int salary)
    {
        this.name = name;
        this.id = id;
        this.title = title;
        this.salary = salary;
    }

    public string GetName()
    {
        return this.name;
    }

    public void Print()
    {
        Console.WriteLine("{0} - {1} - {2} - {3}", id, name, title, salary);
    }
}

using System;

class MonoBehaviour
{
    public bool enabled = true;
    public Vector2 position;
    public string name;
    private static int constructedCount = 0;

    public MonoBehaviour(Vector2 position, string name)
    {
        this.position = position;
        this.name = name;
        constructedCount++;
    }

    public void Print()
    {
        Console.WriteLine("{0} is at {1}, {2}", name, position.x, position.y);
    }

    public static int GetConstructedCount()
    {
        return constructedCount;
    }

    public int GetB()
    {
        return constructedCount;
    }
}

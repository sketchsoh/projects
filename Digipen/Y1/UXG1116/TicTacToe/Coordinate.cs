public class Coordinate
{
    private int x;
    private int y;
    private string value;

    // Coordinate Initializer
    public Coordinate(string value, int x, int y)
    {
        this.value = value;
        this.x = x;
        this.y = y;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }

    public string GetValue()
    {
        return value;
    }

    public void SetValue(string value)
    {
        this.value = value;
    }
}

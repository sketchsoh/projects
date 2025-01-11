using System;

struct Vector2
{
    public float x;
    public float y;
    
    public Vector2(float x, float y) 
    {
        this.x = x;
        this.y = y;
    }
    
    public static float Distance(Vector2 lhs, Vector2 rhs) 
    {
        float x = lhs.x - rhs.x;
        float y = lhs.y - rhs.y;
        return MathF.Sqrt(x*x + y*y); 
    }
}
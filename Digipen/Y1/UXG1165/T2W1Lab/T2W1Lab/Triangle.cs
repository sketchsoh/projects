using System;

class Triangle : Shape
{
    public Triangle(Vector2 p0, Vector2 p1, Vector2 p2)
    {
        Area = MathF.Abs((p0.x * (p1.y - p2.y)) + (p1.x * (p2.y - p0.y)) + (p2.x * (p0.y - p1.y))) / 2;
        Perimeter = Vector2.Distance(p0, p1) + Vector2.Distance(p1, p2) + Vector2.Distance(p2, p0);
        Midpoint.x = (p0.x + p1.x + p2.x) / 3;
        Midpoint.y = (p0.y + p1.y + p2.y) / 3;
    }
}
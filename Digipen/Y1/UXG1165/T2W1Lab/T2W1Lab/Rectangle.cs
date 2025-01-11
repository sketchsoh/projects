using System;

class Rectangle : Shape
{
    public Rectangle(Vector2 p0, Vector2 p1)
    {
        Area = (MathF.Abs(p1.x - p0.x)) * MathF.Abs(p1.y - p0.y);
        Perimeter = ((MathF.Abs(p1.x - p0.x)) * 2 + (MathF.Abs(p1.y - p0.y)) * 2);
        Midpoint.x = (p1.x + p0.x) / 2;
        Midpoint.y = (p1.y + p0.y) / 2;
    }

}


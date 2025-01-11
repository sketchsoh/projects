using System;

class Circle : Shape
{
    public Circle(Vector2 Midpoint, float radius)
    {
        Area = 3.1415f * radius * radius;
        Perimeter = 3.1415f * radius * 2f;
        this.Midpoint = Midpoint;
    }
}


using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;


class Program
{
    static void PrintShapeStats(Shape s)
    {
        Console.WriteLine("  Area: {0}", s.Area);
        Console.WriteLine("  Perimeter: {0}", s.Perimeter);
        Console.WriteLine("  Midpoint: ({0},{1})", s.Midpoint.x, s.Midpoint.y);
    }
    static void TestTriangle(Vector2 p0, Vector2 p1, Vector2 p2)
    {
        Console.WriteLine("Testing triangle with points: ({0},{1}), ({2},{3}), ({4},{5})", p0.x, p0.y, p1.x, p1.y, p2.x, p2.y);
        Shape s = new Triangle(p0, p1, p2);
        PrintShapeStats(s);
    }

    static void TestCircle(Vector2 p, float radius)
    {
        Console.WriteLine("Testing circle with points = ({0},{1}) and radius = {2}", p.x, p.y, radius);
        Shape s = new Circle(p, radius);
        PrintShapeStats(s);
    }

    static void TestRectangle(Vector2 tl, Vector2 br)
    {
        Console.WriteLine("Testing rectangle with top-left = ({0},{1}) and bottom-right = ({2},{3})", tl.x, tl.y, br.x, br.y);
        Shape s = new Rectangle(tl, br);
        PrintShapeStats(s);
    }

    // Entry point of the program
    static void Main(string[] args)
    {

        Console.WriteLine("=== Testing Circles ===");
        TestCircle(new Vector2(0, 0), 10.0f);
        TestCircle(new Vector2(100, 100), 20.0f);
        TestCircle(new Vector2(0, -50), 5.0f);

        Console.WriteLine("=== Testing Rectangle ===");
        TestRectangle(new Vector2(0, 1), new Vector2(0, 1));
        TestRectangle(new Vector2(-50, 50), new Vector2(50, -50));
        TestRectangle(new Vector2(100, 100), new Vector2(150, -100));

        Console.WriteLine("=== Testing Triangle ===");
        TestTriangle(new Vector2(0, 0), new Vector2(1, 0), new Vector2(0, 1));
        TestTriangle(new Vector2(100, 100), new Vector2(50, 50), new Vector2(150, 50));
        TestTriangle(new Vector2(0, -50), new Vector2(-20, 50), new Vector2(20, 50));

    }
}


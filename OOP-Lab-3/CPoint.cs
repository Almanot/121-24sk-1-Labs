using System;

namespace OOP_Lab_3
{
    public class CPoint : СGraphicsObject
    {
        Vector2 vector2 { get; set; }
        public CPoint(Vector2 vector)
        {
            vector2 = vector;
        }
        ~CPoint() { }
        public void Show() 
        {
            Console.WriteLine($"Position on canvas is x={vector2.x} y={vector2.y}");
        }
    }
}
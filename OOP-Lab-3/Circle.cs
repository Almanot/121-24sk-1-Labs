using System;

namespace OOP_Lab_3
{
    public class Circle : CPoint
    {
        float radius { get; set; }
        public Circle(Vector2 vector, float radius) : base(vector)
        {
            this.radius = radius;
        }

        void Show()
        {
            base.Show();
            Console.WriteLine($"Circle radius = {radius}");
        }
    }
}
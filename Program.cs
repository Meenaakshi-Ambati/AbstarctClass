using System;

namespace AbstractClass
{
    public abstract class Shape
    {
        public string Color {get; set; }
        public int Thickness { get; set; }

        public abstract void Draw();
    }

    public class Line : Shape
    {
         public override void Draw()
         {
             Console.WriteLine("Draws Line");
         }

    }

    
    public class Rectangle : Shape
    {
         public override void Draw()
         {
             Console.WriteLine("Draws Rectangle");
         }
         
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Line {Color  = "Red", Thickness = 1 };
            Shape shape2 = new Rectangle {Color  = "blue", Thickness = 2 };

            shape1.Draw();
            shape2.Draw();
        }
    }
}

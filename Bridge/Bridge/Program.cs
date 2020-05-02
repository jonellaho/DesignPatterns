using System;

namespace Bridge
{
    class Program
    {
        public interface IRenderer
        {
            void RenderShape(string shapeName, string color);
        }

        public class VectorRenderer : IRenderer
        {
            public void RenderShape(string shapeName, string color)
            {
                Console.WriteLine($"Vector Renderer to create {shapeName} with {color} color");
            }
        }

        public class RasterRenderer : IRenderer
        {
            public void RenderShape(string shapeName, string color)
            {
                Console.WriteLine($"Raster Renderer to create {shapeName} with {color} color");
            }
        }

        public abstract class Shape
        {
            protected IRenderer Renderer { get; set; }
            public string Color { get; set; }

            public Shape(IRenderer renderer)
            {
                this.Renderer = renderer;
            }

            public abstract void Draw();

        }

        public class Line : Shape
        {
            public Line(IRenderer renderer, string color) : base(renderer)
            {
                this.Color = color;
            }
            public override void Draw()
            {
                Renderer.RenderShape(this.GetType().Name, Color);
            }
        }

        public class Demo
        {
            static void Main(string[] args)
            {

                IRenderer renderer = new VectorRenderer();
                Shape line = new Line(renderer, "Red");

                line.Draw();

            }
        }
    }

}
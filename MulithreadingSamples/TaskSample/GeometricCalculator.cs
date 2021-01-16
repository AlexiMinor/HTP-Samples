using System;
using System.Drawing;

namespace TaskSample
{
    public class GeometricCalculator
    {

        public Rectangle CalculateRectangleDimensions(int width, int height)
        {

            return new Rectangle()
            {
                Perimeter = (width + height) * 2,
                Area = width * height,
                DiagonalLength = Math.Sqrt(width*width+height*height)
            };

            //return CalculateArea(width, height);
        }

        public long CalculateRectangleDimensions(int width, int height, out long area, out double diagonal)
        {
            area = width * height;
            diagonal = Math.Sqrt(width * width + height * height);
            return (width + height) * 2;
        }


        private long CalculatePerimeter(int width, int height)
        {
            return (width + height) * 2;
        }

        private long CalculateArea(int width, int height)
        {
            return width * height;
        }
    }

    public class Rectangle
    {
        public long Perimeter { get; set; }
        public long Area { get; set; }

        public double DiagonalLength { get; set; }

        public Point Point { get; set; }

    }
}
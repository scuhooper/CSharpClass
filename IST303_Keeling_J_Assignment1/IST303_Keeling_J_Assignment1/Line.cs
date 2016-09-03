using System;

namespace IST303_Keeling_J_Assignment1
{
    class Line
    {
        double slope;
        bool isHorizontal = false, isVertical = false;

        // properties
        private double coeffX { get; set; }
        private double coeffY { get; set; }
        private double interceptY { get; set; }

        // constructor for line taking in attributes for x, y, and y intercept
        public Line( double x, double y, double b)
        {
            coeffY = y;
            coeffX = x;
            interceptY = b;
            FindSlope();
        }
        public void FindSlope()
        {
            if (coeffX == 0)
            {
                slope = 0;
                isHorizontal = true;
                Console.WriteLine( "Line {0}x + {1}y = {2} is horizontal and has a slope of {3}.", coeffX, coeffY, interceptY, slope );
            }
            else if (coeffY == 0)
            {
                Console.WriteLine( "Line {0}x + {1}y = {2} is vertical and has an undefined slope.", coeffX, coeffY, interceptY);   // slope does NOT get set here
                isVertical = true;
                slope = 0;
            }
            else
            {
                slope = -coeffX / coeffY;
                Console.WriteLine("Line {0}x + {1}y = {2} has a slope of {3}.", coeffX, coeffY, interceptY, slope);
            }
        }
        public void FindYGivenX( double x)
        {
            if (this.isHorizontal)
                Console.WriteLine("Y = {0} when X = {1}", coeffY, x);
            else if (this.isVertical)
                Console.WriteLine("X can only equal {0} and Y can be any number as the line is vertical", coeffX);
            else
            {
                double y = x * slope;
                Console.WriteLine("Y = {0} when X = {1}", y, x);
            }
        }
        public void FindXGivenY(double y)
        {
            if (this.isHorizontal)
                Console.WriteLine("Y can only equal {0} and X can be any number as the line is horizontal", coeffY);
            else if (this.isVertical)
                Console.WriteLine("X = {0} when Y = {1}", coeffX, y);
            else
            {
                double x = y * slope;
                Console.WriteLine("X = {0} when Y = {1}", x, y);
            }
        }
        public void AreLinesParallel( Line line1, Line line2)
        {
            if ( ( line1.isVertical && !line2.isVertical ) || ( !line1.isVertical && line2.isVertical ) || ( line1.slope != line2.slope ) )
            {
                Console.WriteLine("The lines are not parallel.");
            }
            else
            {
                Console.WriteLine("The lines are parallel.");
            }
        }
        public void AreLinesPerpendicular( Line line1, Line line2)
        {
            if ( ( ( line1.slope * line2.slope ) == -1 ) || ( line1.isVertical && line2.isHorizontal ) || ( line1.isVertical && line2.isHorizontal ) )
            {
                Console.WriteLine("The lines are perpendicular.");
            }
            else
            {
                Console.WriteLine("The lines are not perpendicular.");
            }
        }
    }
}

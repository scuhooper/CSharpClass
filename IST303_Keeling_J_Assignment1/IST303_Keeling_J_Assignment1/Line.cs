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
        public double FindYGivenX( double x)
        {
            if (this.isHorizontal)
            {
                Console.WriteLine("Y = {0} when X = {1}", coeffY, x);
                return coeffY;
            }
            else if ( this.isVertical ) {
                Console.WriteLine( "X can only equal {0} and Y can be any number as the line is vertical", coeffX );
                return 0;
            }
            else {
                double y = ( x * slope ) + interceptY;
                Console.WriteLine( "Y = {0} when X = {1}", y, x );
                return y;
            }
        }
        public double FindXGivenY(double y)
        {
            if ( this.isHorizontal ) {
                Console.WriteLine( "Y can only equal {0} and X can be any number as the line is horizontal", coeffY );
                return 0;
            }
            else if ( this.isVertical ) {
                Console.WriteLine( "X = {0} when Y = {1}", coeffX, y );
                return coeffX;
            }
            else {
                double x = ( y - interceptY ) / slope;
                Console.WriteLine( "X = {0} when Y = {1}", x, y );
                return x;
            }
        }
        public bool AreLinesParallel( Line line1, Line line2)
        {
            if ( ( line1.isVertical && !line2.isVertical ) || ( !line1.isVertical && line2.isVertical ) || ( line1.slope != line2.slope ) )
            {
                Console.WriteLine("The lines are not parallel.");
                return false;
            }
            else
            {
                Console.WriteLine("The lines are parallel.");
                return true;
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

        public void LineIntersection( Line line1, Line line2 ) {
            if ( !AreLinesParallel( line1, line2 ) ) {
                double interX, interY, determinant;
                determinant = line1.coeffX * line2.coeffY - line2.coeffX * line1.coeffY;
                interX = ( line2.coeffY * line1.interceptY - line1.coeffY * line2.interceptY ) / determinant;
                interY = ( line1.coeffX * line2.interceptY - line2.coeffX * line1.interceptY ) / determinant;
                Console.WriteLine( "The two lines will intersect at point ({0}, {1}).", interX, interY );
            }
            else {
                Console.WriteLine( "The lines are parallel and do not intersect" );
            }
        }
    }
}

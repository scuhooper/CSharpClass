using System;

namespace IST303_Keeling_J_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line(1, 4, 5);
            line1.FindXGivenY(8);
            line1.FindYGivenX(9);

            Line line2 = new Line(0, 2, 8);
            Line line3 = new Line(2, 0, 3);

            line2.AreLinesParallel( line2, line3 );
            line3.AreLinesPerpendicular( line3, line2 );
            line2.FindXGivenY(8);
            line2.FindYGivenX(8);
            line3.FindXGivenY(8);
            line3.FindYGivenX(8);

            Line line4 = new Line(2, 4, 6);
            Line line5 = new Line(4, 8, 12);

            line4.AreLinesParallel(line4, line5);
            line5.AreLinesPerpendicular(line4, line5);

            Line line6 = new Line(1, -.25, 1);
            Line line7 = new Line(1, 4, 5);

            line6.AreLinesParallel(line6, line7);
            line7.AreLinesPerpendicular(line6, line7);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleIntersection {
    class Program {
        static void Main( string[] args ) {
            var a = Console.ReadLine();
            var b = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(str => Double.Parse(str.Trim())).ToList();

            double x1,y1,r1,x2,y2,r2;

            // for convenience, make circle 1 the smaller circle
            if( b[ 2 ] < b[ 5 ] ) {
                x1 = b[ 0 ];
                y1 = b[ 1 ];
                r1 = b[ 2 ];
                x2 = b[ 3 ];
                y2 = b[ 4 ];
                r2 = b[ 5 ];
            } else {
                x2 = b[ 0 ];
                y2 = b[ 1 ];
                r2 = b[ 2 ];
                x1 = b[ 3 ];
                y1 = b[ 4 ];
                r1 = b[ 5 ];
            }

            if( x1 == x2 && y1 == y2 ) {
                if( r1 == r2 ) {
                    Console.WriteLine( -1 );
                } else {
                    Console.WriteLine( 0 );
                }
            } else {

                var centerDistance = Distance( x1, y1, x2, y2 );

                // if the center of the smaller circle is in the big circle
                if( r2 > centerDistance ) {

                    if( centerDistance + r1 < r2 ) {
                        Console.WriteLine( 0 );
                    } else if( centerDistance + r1 == r2 ) {
                        Console.WriteLine( 1 );
                    } else {
                        Console.WriteLine( 2 );
                    }

                } else {

                    var radiusSum = r1 + r2;

                    if( centerDistance > radiusSum ) {
                        Console.WriteLine( 0 );
                    } else if( centerDistance == radiusSum ) {
                        Console.WriteLine( 1 );
                    } else {
                        Console.WriteLine( 2 );
                    }
                }
            }
        }

        static double Distance( double x1, double y1, double x2, double y2 ) {
            return Math.Abs( Math.Sqrt( (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) ) );
        }
    }
}

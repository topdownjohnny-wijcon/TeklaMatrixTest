using System;
using System.Reflection;
using Tekla.Structures.Geometry3d;

namespace TeklaMatrixTest
{
    public static class Program
    {
        public static void Main()
        {
            var teklaAssembly=Assembly.GetAssembly(typeof(Matrix)).GetName().Version;
            Console.WriteLine($"Test: {teklaAssembly}");
            Console.WriteLine();

            var lokaalMiddelpunt2 = new Vector(-77.071613073349, 14.500000953674316, 0.0);
            Console.WriteLine(lokaalMiddelpunt2);


            var lokaalNaarWereld2 = new Matrix();
            lokaalNaarWereld2[0, 0] = 0;
            lokaalNaarWereld2[0, 1] = 1;
            lokaalNaarWereld2[0, 2] = 0;
            lokaalNaarWereld2[1, 0] = -1;
            lokaalNaarWereld2[1, 1] = 0;
            lokaalNaarWereld2[1, 2] = 0;
            lokaalNaarWereld2[2, 0] = 0;
            lokaalNaarWereld2[2, 1] = 0;
            lokaalNaarWereld2[2, 2] = 1;
            lokaalNaarWereld2[3, 0] = 10125;
            lokaalNaarWereld2[3, 1] = 13427.0716166353;
            lokaalNaarWereld2[3, 2] = 1250;
            Console.WriteLine(lokaalNaarWereld2);

            var trans2 = MatrixFactory.FromCoordinateSystem(new CoordinateSystem(lokaalMiddelpunt2, new Vector(1, 0, 0), new Vector(0, 1, 0)));
            Console.WriteLine(trans2);
            lokaalNaarWereld2 = lokaalNaarWereld2 * trans2;
            Console.WriteLine(lokaalNaarWereld2);
        }
    }
}
using System;
using System.Reflection;
using Tekla.Structures.Geometry3d;

namespace TeklaMatrixTest
{
    public static class Program
    {
        public static void Main()
        {
            var teklaAssembly = Assembly.GetAssembly(typeof(Matrix)).GetName().Version;
            Console.WriteLine($"Test: {teklaAssembly}");
            Console.WriteLine();

            var point = new Vector(-77.071613073349, 14.500000953674316, 0.0);
            Console.WriteLine(point);


            var matrix = new Matrix();
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 0;
            matrix[1, 0] = -1;
            matrix[1, 1] = 0;
            matrix[1, 2] = 0;
            matrix[2, 0] = 0;
            matrix[2, 1] = 0;
            matrix[2, 2] = 1;
            matrix[3, 0] = 10125;
            matrix[3, 1] = 13427.0716166353;
            matrix[3, 2] = 1250;
            Console.WriteLine(matrix);

            var transform = MatrixFactory.FromCoordinateSystem(new CoordinateSystem(point, new Vector(1, 0, 0), new Vector(0, 1, 0)));
            Console.WriteLine(transform);
            
            matrix = matrix * transform;
            Console.WriteLine(matrix);
        }
    }
}
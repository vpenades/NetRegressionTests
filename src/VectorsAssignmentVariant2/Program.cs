using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var v2 = new Vector3(-48, -10, 82);
            var v1 = new Vector3(29, -15, 44);
            var v0 = new Vector3(13, 34, 114);

            DefineTriangle(v0, v1, v2);
        }

        private static void DefineTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            v0.Z = 0;
            v1.Z = 0;
            v2.Z = 0;

            var s0 = new Vector2(v0.X, v0.Y);
            var s1 = new Vector2(v1.X, v1.Y);
            var s2 = new Vector2(v2.X, v2.Y);
        }
    }
}

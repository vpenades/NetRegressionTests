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

            DefineTriangle(v0,  v1,  v2);
        }

        private static void DefineTriangle(Vector3 v0,  Vector3 v1,  Vector3 v2)
        {            
            v0.Z = 1 / v0.Z;
            v1.Z = 1 / v1.Z;
            v2.Z = 1 / v2.Z;           

            var triangle = new Triangle(new Vector2(v0.X, v0.Y), new Vector2(v1.X, v1.Y), new Vector2(v2.X, v2.Y));            
        }
    }

    struct Triangle
    {
        public Triangle(Vector2 a, in Vector2 b, in Vector2 c)
        {
            _A = a;
            _B = b;
            _C = c;                    
        }        

        private readonly Vector2 _A;
        private readonly Vector2 _B;
        private readonly Vector2 _C;
    }
}

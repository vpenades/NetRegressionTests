using System;
using System.Numerics;

namespace JitCrashPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IntPtr.Size != 8) throw new InvalidOperationException("must run in 64 bits");            

            var map = new ItemRunner();

            map.UpdateItem(0,10);            
        }
    }

    class Item
    {
        public Vector3 _Position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    class ItemRunner
    {
        public ItemRunner()
        {
            for (int i = 0; i < _Pool.Length; ++i) { _Pool[i] = new Item(); }
        }

        private const float _LenghtZ = 1000.0f;

        private static readonly Vector3 _Start = new Vector3(0.0f, -1021.7f, -3451.3f);
        private static readonly Vector3 _Slope = new Vector3(0.0f, 0.286f, 0.958f);

        private Item[] _Pool = new Item[30];

        private Item _LastGenerated;        

        public void UpdateItem(float fDelta, int depth)
        {
            if (depth == 0) return;

            for (int i = 0; i < _Pool.Length; i++)
            {
                var vDelta = _Slope * fDelta;

                if (_LastGenerated != null) _Pool[i]._Position = _LastGenerated._Position - _Slope * _LenghtZ;
                else _Pool[i]._Position = _Start - vDelta;

                _LastGenerated = _Pool[i];

            }

            UpdateItem(0, depth-1);            
        }
    }
}

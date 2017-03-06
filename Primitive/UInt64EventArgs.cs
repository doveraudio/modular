using System;
namespace Modular.Primitive
{
    public class UInt64EventArgs : EventArgs
    {
        private UInt64 _data;
        public UInt64EventArgs() { }

        public UInt64 Data { get { return _data; } set { _data = value; } }

    }
}
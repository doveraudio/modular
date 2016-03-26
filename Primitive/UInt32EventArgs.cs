using System;
namespace Modular.Primitive
{

    public class UInt32EventArgs : EventArgs
    {
        private UInt32 _data;
        public UInt32EventArgs() { }

        public UInt32 Data { get { return _data; } set { _data = value; } }

    }
}
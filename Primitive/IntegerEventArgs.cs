using System;
namespace Modular.Primitive
{
    public class IntegerEventArgs : EventArgs
    {
        private int _data;
        public IntegerEventArgs() { }

        public int Data { get { return _data; } set { _data = value; } }

    }
}
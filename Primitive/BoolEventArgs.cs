using System;
namespace Modular.Primitive
{

    public class BoolEventArgs : EventArgs
    {
        private bool _data;
        public BoolEventArgs() { }

        public bool Data { get { return _data; } set { _data = value; } }

    }
}
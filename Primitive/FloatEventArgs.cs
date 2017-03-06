using System;
namespace Modular.Primitive
{
    
    public class FloatEventArgs : EventArgs
    {
        private float _data;
        public FloatEventArgs() { }

        public float Data { get { return _data; } set { _data = value; } }

    }

}
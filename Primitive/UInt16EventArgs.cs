
using System;
namespace Modular.Primitive
{

    public class UInt16EventArgs : EventArgs {
        private UInt16 _data;
        public UInt16EventArgs() { }

        public UInt16 Data { get { return _data; } set { _data = value; } }

    }

}
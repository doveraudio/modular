using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular.Primitive.Generic
{
    abstract class EventArgs<T> : EventArgs
    {
        private T _data;
        public EventArgs() { }

        public T Data { get { return _data; } set { _data = value; } }
    }
}

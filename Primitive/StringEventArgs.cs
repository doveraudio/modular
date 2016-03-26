using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular.Primitive
{
    public class StringEventArgs : EventArgs
    {
        private string _data;
        public StringEventArgs() { }

        public string Data { get { return _data; } set { _data = value; } }

    }
}

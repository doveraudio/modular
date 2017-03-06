using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular.Primitive.Generic
{
    abstract class Value<T>
    {
        public Value() {
            
        }
        public T Data { get; set; }

        public virtual void Read() {

        }



    }
}

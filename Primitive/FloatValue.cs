
using System;
namespace Modular.Primitive
{
   public class FloatValue
    {
        public float Data;
        public FloatEventArgs Read()
        {
            FloatEventArgs e = new FloatEventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
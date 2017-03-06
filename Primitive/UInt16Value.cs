
using System;
namespace Modular.Primitive
{
   public class UInt16Value
    {
        public UInt16 Data;
        public UInt16EventArgs Read()
        {
            UInt16EventArgs e = new UInt16EventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
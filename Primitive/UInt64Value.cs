using System;
namespace Modular.Primitive
{
   public class UInt64Value
    {
        public UInt64 Data;
        public UInt64EventArgs Read()
        {
            UInt64EventArgs e = new UInt64EventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
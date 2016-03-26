using System;
namespace Modular.Primitive
{
   public class UInt32Value
    {
        public UInt32 Data;
        public UInt32EventArgs Read()
        {
            UInt32EventArgs e = new UInt32EventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
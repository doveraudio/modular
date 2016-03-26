using System;
namespace Modular.Primitive
{
   public class IntegerValue
    {
        public int Data;
        public IntegerEventArgs Read()
        {
            IntegerEventArgs e = new IntegerEventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
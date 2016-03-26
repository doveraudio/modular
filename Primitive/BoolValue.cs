using System;
namespace Modular.Primitive
{
   public class BoolValue
    {
        public bool Data;
        public BoolEventArgs Read()
        {
            BoolEventArgs e = new BoolEventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
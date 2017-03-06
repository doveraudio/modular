using System;
namespace Modular.Primitive
{
   public class StringValue
    {
        public string Data;
        public StringEventArgs Read()
        {
            StringEventArgs e = new StringEventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
using System;
namespace Modular.Primitive
{
   public class UInt64Output
    {
        public event EventHandler<UInt64EventArgs> Received;
        public virtual void Receive(object sender, UInt64EventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(UInt64EventArgs e)
        {
            if (this.Received == null)
            {
                System.Console.WriteLine(e.Data);
            }
            else {
                this.Received(this, e);
            }

        }



    }
}
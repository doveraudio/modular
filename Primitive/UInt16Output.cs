using System;
namespace Modular.Primitive
{
   public class UInt16Output
    {
        public event EventHandler<UInt16EventArgs> Received;
        public virtual void Receive(object sender, UInt16EventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(UInt16EventArgs e)
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
using System;
namespace Modular.Primitive
{
   public class UInt32Output
    {
        public event EventHandler<UInt32EventArgs> Received;
        public virtual void Receive(object sender, UInt32EventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(UInt32EventArgs e)
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
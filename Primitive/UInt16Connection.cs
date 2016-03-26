using System;
namespace Modular.Primitive
{
   public class UInt16Connection
    {
        public event EventHandler<UInt16EventArgs> Received;

        public event EventHandler<UInt16EventArgs> Sent;
        public virtual void Receive(object sender, UInt16EventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, UInt16EventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(UInt16EventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(UInt16EventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }

    }
}
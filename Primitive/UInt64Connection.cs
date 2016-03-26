using System;
namespace Modular.Primitive
{
   public class UInt64Connection
    {
        public event EventHandler<UInt64EventArgs> Received;

        public event EventHandler<UInt64EventArgs> Sent;
        public virtual void Receive(object sender, UInt64EventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, UInt64EventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(UInt64EventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(UInt64EventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }

    }
}
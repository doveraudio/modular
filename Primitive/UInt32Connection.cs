using System;
namespace Modular.Primitive
{
   public class UInt32Connection
    {
        public event EventHandler<UInt32EventArgs> Received;

        public event EventHandler<UInt32EventArgs> Sent;

        public virtual void Receive(object sender, UInt32EventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, UInt32EventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(UInt32EventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(UInt32EventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }
    }
}
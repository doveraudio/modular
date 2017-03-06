using System;
namespace Modular.Primitive
{
   public class BoolConnection
    {
        public event EventHandler<BoolEventArgs> Received;

        public event EventHandler<BoolEventArgs> Sent;

        public virtual void Receive(object sender, BoolEventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, BoolEventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(BoolEventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(BoolEventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }
    }
}
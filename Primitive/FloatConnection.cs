
using System;
namespace Modular.Primitive
{
   public class FloatConnection
    {
        public event EventHandler<FloatEventArgs> Received;

        public event EventHandler<FloatEventArgs> Sent;
        public virtual void Receive(object sender, FloatEventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, FloatEventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(FloatEventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(FloatEventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }

    }
}
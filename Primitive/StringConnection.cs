using System;
namespace Modular.Primitive
{
   public class StringConnection
    {
        public event EventHandler<StringEventArgs> Received;

        public event EventHandler<StringEventArgs> Sent;
        public virtual void Receive(object sender, StringEventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, StringEventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(StringEventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(StringEventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }

    }
}
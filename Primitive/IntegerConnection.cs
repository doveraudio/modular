using System;
namespace Modular.Primitive
{
    
   public class IntegerConnection
    {
        public event EventHandler<IntegerEventArgs> Received;

        public event EventHandler<IntegerEventArgs> Sent;
        public virtual void Receive(object sender, IntegerEventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, IntegerEventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(IntegerEventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(IntegerEventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }

    }
}
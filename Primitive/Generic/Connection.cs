using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular.Primitive.Generic
{
    abstract class Connection<T>
    {
        public event EventHandler<EventArgs<T>> Received;

        public event EventHandler<EventArgs<T>> Sent;
        public virtual void Receive(object sender, EventArgs<T> e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, EventArgs<T> e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(EventArgs<T> e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(EventArgs<T> e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }

    }
}

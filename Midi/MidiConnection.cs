using System;
namespace Modular.Midi
{
   public class MidiConnection
    {
        public event EventHandler<MidiEventArgs> Received;

        public event EventHandler<MidiEventArgs> Sent;

        public virtual void Receive(object sender, MidiEventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, MidiEventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(MidiEventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(MidiEventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }
    }
}

using System;
namespace Modular.Primitive
{
   public class FloatOutput
    {
        public event EventHandler<FloatEventArgs> Received;
        public virtual void Receive(object sender, FloatEventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(FloatEventArgs e)
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
using System;
namespace Modular.Primitive
{
   public class IntegerOutput
    {
        public event EventHandler<IntegerEventArgs> Received;
        public virtual void Receive(object sender, IntegerEventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(IntegerEventArgs e)
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
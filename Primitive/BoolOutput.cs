using System;
namespace Modular.Primitive
{
   public class BoolOutput
    {
        public event EventHandler<BoolEventArgs> Received;
        public virtual void Receive(object sender, BoolEventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(BoolEventArgs e)
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
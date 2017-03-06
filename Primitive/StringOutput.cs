using System;
namespace Modular.Primitive
{
   public class StringOutput
    {
        public event EventHandler<StringEventArgs> Received;
        public virtual void Receive(object sender, StringEventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(StringEventArgs e)
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
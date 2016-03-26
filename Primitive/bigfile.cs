
using System;
namespace Modular.Primitive
{
    class FloatOutput
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
using System;
namespace Modular.Primitive
{

    public class UInt16EventArgs : EventArgs {
        private UInt16 _data;
        public UInt16EventArgs() { }

        public UInt16 Data { get { return _data; } set { _data = value; } }

    }

}
using System;
namespace Modular.Primitive
{
    class UInt16Value
    {
        public UInt16 Data;
        public UInt16EventArgs Read()
        {
            UInt16EventArgs e = new UInt16EventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
using System;
namespace Modular.Primitive
{
    class UInt16Connection
    {
        public event EventHandler<UInt16EventArgs> Received;

        public event EventHandler<UInt16EventArgs> Sent;
        public virtual void Receive(object sender, UInt16EventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, UInt16EventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(UInt16EventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(UInt16EventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }

    }
}
using System;
namespace Modular.Primitive
{
    class UInt16Output
    {
        public event EventHandler<UInt16EventArgs> Received;
        public virtual void Receive(object sender, UInt16EventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(UInt16EventArgs e)
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
using System;
namespace Modular.Primitive
{

    public class UInt32EventArgs : EventArgs
    {
        private UInt32 _data;
        public UInt32EventArgs() { }

        public UInt32 Data { get { return _data; } set { _data = value; } }

    }
}
using System;
namespace Modular.Primitive
{
    class UInt32Value
    {
        public UInt32 Data;
        public UInt32EventArgs Read()
        {
            UInt32EventArgs e = new UInt32EventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
using System;
namespace Modular.Primitive
{
    class UInt32Connection
    {
        public event EventHandler<UInt32EventArgs> Received;

        public event EventHandler<UInt32EventArgs> Sent;
        public virtual void Receive(object sender, UInt32EventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, UInt32EventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(UInt32EventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }
}
using System;
namespace Modular.Primitive
{
        public virtual void OnReceived(UInt32EventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }

    }
}
using System;
namespace Modular.Primitive
{
    class UInt32Output
    {
        public event EventHandler<UInt32EventArgs> Received;
        public virtual void Receive(object sender, UInt32EventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(UInt32EventArgs e)
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
using System;
namespace Modular.Primitive
{
    public class UInt64EventArgs : EventArgs
    {
        private UInt64 _data;
        public UInt64EventArgs() { }

        public UInt64 Data { get { return _data; } set { _data = value; } }

    }
}
using System;
namespace Modular.Primitive
{
    class UInt64Value
    {
        public UInt64 Data;
        public UInt64EventArgs Read()
        {
            UInt64EventArgs e = new UInt64EventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
using System;
namespace Modular.Primitive
{
    class UInt64Connection
    {
        public event EventHandler<UInt64EventArgs> Received;

        public event EventHandler<UInt64EventArgs> Sent;
        public virtual void Receive(object sender, UInt64EventArgs e)
        {
            this.OnReceived(e);
        }

        public virtual void Send(object sender, UInt64EventArgs e)
        {

            this.OnSent(e);

        }

        public virtual void OnSent(UInt64EventArgs e)
        {
            if (this.Sent != null)
            {
                this.Sent(this, e);

            }

        }

        public virtual void OnReceived(UInt64EventArgs e)
        {
            if (this.Received != null)
            {
                this.Received(this, e);
            }

        }

    }
}
using System;
namespace Modular.Primitive
{
    class UInt64Output
    {
        public event EventHandler<UInt64EventArgs> Received;
        public virtual void Receive(object sender, UInt64EventArgs e)
        {
            this.OnReceived(e);

        }

        public virtual void OnReceived(UInt64EventArgs e)
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
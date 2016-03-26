using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;
using Modular.OpenToolKit.GamingDevice.General;

namespace Modular.OpenToolKit.GamingDevice.General
{
   public class ActionEvent
    {
       
            public ActionEvent()
            {


            }

            public ActionMessage Message { get; set; }

            public event EventHandler<ActionEventArgs> Action;

            public virtual void OnAction(ActionEventArgs e)
            {
                EventHandler<ActionEventArgs> handler = this.Action;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
        
    }
}

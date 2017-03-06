using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;
namespace Modular.OpenToolKit.GamingDevice.General
{
   public class ActionMessage
    {
        public int Instance { get; set; }

        public GamePadState GamepadState { get { return GamePad.GetState(this.Instance); } }

        public JoystickState JoystickState { get { return Joystick.GetState(this.Instance); } }
    }
}

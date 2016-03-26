using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;
namespace Modular.OpenToolKit.GamingDevice.General
{
    public class Button
    {
        private bool _state;
        private bool _old_state;
        private int _index;
        private int _instance;
        public Button()
        {
            _instance = 0;
            _index = 0;
            this._state = Joystick.GetState(_instance).IsButtonDown((JoystickButton)_index);
            this._old_state = this._state;
        }

        public Button(int instance, int index)
        {
            _instance = instance;
            _index = index;

            this._state = Joystick.GetState(_instance).IsButtonDown((JoystickButton)_index);
            this._old_state = this._state;
        }

        public Button(int instance, int index, EventHandler<ActionEventArgs> pressed, EventHandler<ActionEventArgs> released)
        {
            _instance = instance;
            _index = index;
            this.Pressed = pressed;
            this.Released = released;

            this._state = Joystick.GetState(_instance).IsButtonDown((JoystickButton)_index);
            this._old_state = this._state;
        }

        public bool State { get {
                if (this._old_state != this._state)
                {
                    this._old_state = this._state;
                    this._state = Joystick.GetState(_instance).IsButtonDown((JoystickButton)_index);
                    if (this._state) { this.Press(); } else { this.Release(); }
                }
                return this._state;
            }
        }
        public void Poll() {
            
            var x = this.State;

        }


        public event EventHandler<ActionEventArgs> Pressed;

        public event EventHandler<ActionEventArgs> Released;

        public int Index { get { return _index; } }

        public int Instance { get { return _instance; } }
        public virtual void Press()
        {
            this.OnPressed(new ActionEventArgs(this.Instance));
        }

        public virtual void Release()
        {
            this.OnReleased(new ActionEventArgs(this.Instance));
        }

        protected virtual void OnPressed(ActionEventArgs e)
        {
            if (this.Pressed != null)
            {
                this.Pressed(this, e);
            }
        }

        protected virtual void OnReleased(ActionEventArgs e)
        {
            if (this.Released != null)
            {
                this.Released(this, e);
            }
        }
    }
}

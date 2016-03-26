using System;

using System.Collections.ObjectModel;
using Modular.OpenToolKit.GamingDevice.General;
using OpenTK;
using OpenTK.Input;

namespace Modular.OpenToolKit.GamingDevice.Devices { 

    public class Joystick
    {
        public Joystick()
        {
            this.Instance = 0;
            this.ButtonCount = 20;
            this.oldstate = this.State;
            this.InitializeButtons();
        }
        public Joystick(int instance)
        {
            this.Instance = instance;
            this.ButtonCount = 20;
            this.oldstate = this.State;
            this.InitializeButtons();
        }

        public Joystick(int instance, int buttonCount)
        {
            this.Instance = instance;
            this.ButtonCount = buttonCount;
            this.oldstate = this.State;
            this.InitializeButtons();
        }

        protected void InitializeButtons()
        {
            this._buttons = new Collection<Button>();
            for (int i = 0; i < this.ButtonCount; i++)
            {
                this.Buttons.Add(new Button(this.Instance, i));
            }
        }
        private int _buttonCount;

        public int ButtonCount { get { return _buttonCount; } set { _buttonCount = value; } }

        private Collection<Button> _buttons;

        public Collection<Button> Buttons { get { return _buttons; } }

        private OpenTK.Input.JoystickState oldstate;

        public int Instance { get; set; }

        public OpenTK.Input.JoystickState State { get { return OpenTK.Input.Joystick.GetState(this.Instance); } }

        public OpenTK.Input.JoystickCapabilities Capabilities
        {
            get
            {
                return OpenTK.Input.Joystick.GetCapabilities(this.Instance);
            }
        }

        public virtual void OnAction(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = this.Action;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public bool Changed()
        {
            return !this.State.Equals(this.oldstate);
        }

        public void Update()
        {
            this.oldstate = this.State;
        }

        public virtual void Poll()
        {
            var state = this.State;

            foreach (Button button in this.Buttons)
            {
                if (this.oldstate.GetButton((JoystickButton)button.Index) != state.GetButton((JoystickButton)button.Index))
                {
                    if (state.GetButton((JoystickButton)button.Index) == ButtonState.Pressed)
                    {
                        button.Press();
                    }
                    if (state.GetButton((JoystickButton)button.Index) == ButtonState.Released)
                    {
                        button.Release();
                    }
                }

            }

        }


        public event EventHandler<ActionEventArgs> Action;

    }
}

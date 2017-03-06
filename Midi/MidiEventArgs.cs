using System;
namespace Modular.Midi
{
    public class MidiEventArgs : EventArgs
    {
        private MidiMessage _data;
        public MidiEventArgs()
        {_data = new MidiMessage(); }

        public MidiMessage Data { get { return _data; } set { _data = value; } }

        
    }
}
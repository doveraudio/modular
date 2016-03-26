using System;
namespace Modular.Midi
    class MidiValue
    {
        public MidiMessage Data;
        public MidiEventArgs Read()
        {
            MidiEventArgs e = new MidiEventArgs();
            e.Data = this.Data;
            return e;
        }
    }
}
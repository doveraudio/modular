using System;
namespace Modular.Midi
{
    public class MidiEvent
    {
        public MidiEvent()
        {


        }

        public MidiMessage Message { get; set; }

        public event EventHandler<MidiEventArgs> Midi;

        public virtual void OnMidi(MidiEventArgs e)
        {
            EventHandler<MidiEventArgs> handler = this.Midi;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
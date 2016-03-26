using System;
namespace Modular.Midi
{
    public class MidiMessage
    {
        public string Command { get; set; }
        public int MidiDevice { get; set; }
        public int MidiChannel { get; set; }
        public int Data1 { get; set; }
        public int Data2 { get; set; }
    }
}
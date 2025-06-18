using System;

namespace Task_2___Random_Number_Generation
{
    internal class SplitMix64
    {
        private ulong state;

        public SplitMix64()
        {
            state = (ulong)DateTime.Now.Ticks;
        }

        public ulong Next(ulong min, ulong max)
        {
            state += 0x9E3779B97F4A7C15;
            ulong z = state;
            z = (z ^ (z >> 30)) * 0xBF58476D1CE4E5B9;
            z = (z ^ (z >> 27)) * 0x94D049BB133111EB;
            z = z ^ (z >> 31);
            return min + z % (max - min + 1);
        }
    }
}

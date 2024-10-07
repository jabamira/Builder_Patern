using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CPU
    {
        public string Model { get; }
        public float GHZ { get; }
        public CPU(string model, float ghz)
        {
            Model = model;
            GHZ = ghz;
            
        }
    }

    public class Motherboard
    {
        public string Model { get; }
        public Motherboard(string model)
        {
            Model = model;
        }
    }

    public class RAM
    {
        public string Model { get; }
        public int Frequency { get; }
        public int Size { get; }
        public RAM(int size, string model, int frequency)
        {
            Size = size;

            Model = model;
            Frequency = frequency;
        }
    }

    public class Storage
    {
        public int Capacity { get; }
        public string Type { get; }
        public string Model{ get; }

        public int Speed_read { get; }
        public int Speed_write { get; }
        public Storage(string type, string model, int capacity, int speed_read, int speed_write)
        {
            Type = type;
            Capacity = capacity;
            Model = model;
            Speed_read = speed_read;
            Speed_write = speed_write;
        }
    }

    public class GPU
    {
        public string Model { get; }
        public int VRAM { get; }
        public GPU(string model, int vram)
        {
            Model = model;
            VRAM = vram;

        }
    }
}

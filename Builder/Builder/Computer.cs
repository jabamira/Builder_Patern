using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Computer
    {
        public CPU Cpu { get; }
        public Motherboard Motherboard { get; }
        public RAM Ram { get; }
        public Storage Storage { get; }
        public GPU Gpu { get; }

        public Computer(CPU cpu, Motherboard motherboard, RAM ram, Storage storage, GPU gpu)
        {
            Cpu = cpu;
            Motherboard = motherboard;
            Ram = ram;
            Storage = storage;
            Gpu = gpu;
        }
        public override string ToString()
        {
            return $"Computer \nCPU: {Cpu.Model}, Ghz:{Cpu.GHZ}\nMotherboard: {Motherboard.Model}\nRAM: {Ram.Model} , Frequency:{Ram.Frequency}, Size:{Ram.Size}GB\nStorage: {Storage.Model}, Type: {Storage.Type}, Capacity: {Storage.Capacity}GB, Speed read:{Storage.Speed_read} ,Speed write {Storage.Speed_write}\nGPU: {Gpu.Model}, VRAM size: {Gpu.VRAM}";
        }
    }
}

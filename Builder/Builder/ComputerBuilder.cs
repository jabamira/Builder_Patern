using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ComputerBuilder
    {
        private CPU CPU;
        private Motherboard Motherboard;
        private RAM RAM;
        private Storage Storage;
        private GPU GPU;

        public ComputerBuilder SetCPU(string model , float ghz)
        {
            CPU = new CPU(model, ghz);
            return this;
        }

        public ComputerBuilder SetMotherboard(string model)
        {
            Motherboard = new Motherboard(model);
            return this;
        }

        public ComputerBuilder SetRAM(int size, string model, int frequency)
        {
            RAM = new RAM(size, model, frequency);
            return this;
        }

        public ComputerBuilder SetStorage(string type, string model,int capacity,  int speed_read, int speed_write)
        {
            Storage = new Storage(type,model, capacity, speed_read, speed_write);
            return this;
        }

        public ComputerBuilder SetGPU(string model, int vram)
        {
            GPU = new GPU(model, vram);
            return this;
        }

        public Computer Build()
        {
            return new Computer(CPU, Motherboard, RAM, Storage, GPU);
        }
    }

    
        
}

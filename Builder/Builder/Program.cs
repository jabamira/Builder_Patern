using Builder;

class Program
{
    static void Main(string[] args)
    {
        ComputerBuilder builder = new ComputerBuilder();
        Computer computer = builder
            .SetCPU("AMD Ryzen 7 PRO 5750G OEM",  3.8f  )
            .SetMotherboard("ASUS ROG")
            .SetRAM(32, "AMD Radeon R9 Gamer Series [R9S416G3206U2K]", 3200)
            .SetGPU("Palit GeForce RTX 3060 Dual OC (LHR)",12)
            .SetStorage("SSD M.2", "Samsung 980 [MZ-V8V500BW]", 500, 3100,2600)

            .Build();

        Console.WriteLine(computer);
    }
}
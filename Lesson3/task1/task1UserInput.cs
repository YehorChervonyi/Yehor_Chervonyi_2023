using task1.Classes;
using task1.Classes.Details;

var computer = new Computer();
int iterrations = new int();
int cpuslotss = new int();
int gpuslots = new int();
int ramslots = new int();
int driveslots = new int();
string lifetime = "";
string coninterface = "";

while (true)
{
    Console.Write("---Menu---\n" +
                  "1 | Add Motherboard\n" +
                  "2 | Add CPU\n" +
                  "3 | Add RAM\n" +
                  "4 | Add GPU\n" +
                  "5 | Add Drive\n" +
                  "i | Info\n" +
                  "q | Exit programm\n" +
                  "What to add : ");

    var userInput = Console.ReadLine();
    
    switch (userInput)
    {
        case "1":
            computer.AddMboard(computer.UserAskMboard());
            cpuslotss = computer.Mboard.CpuSlots;
            gpuslots = computer.Mboard.PcieSlots;
            ramslots = computer.Mboard.SlotsCount;
            driveslots = computer.Mboard.ConnectInterface.Values.Count;
            break;
        
        case "2":
            if (computer.Mboard != null)
            {
                Console.Write("Ammount of CPUs: ");
                iterrations = Convert.ToInt32(Console.ReadLine());
                if (iterrations <= cpuslotss)
                {
                    for (int i = 0; i < iterrations; i++)
                    {
                        computer.Cpu.Add(computer.UserAskCpu());
                        cpuslotss -= 1;    
                    }
                }
                else
                {
                    Console.WriteLine("Ammount of CPUs is to much that you Motherboard suppport!");
                }
            }
            else
            {
                Console.WriteLine("No motherboard, please add it");
            }
            break;
        
        
        case "3":
            if (computer.Mboard != null)
            {
                Console.Write("Ammount of RAMs: ");
                iterrations = Convert.ToInt32(Console.ReadLine());
                if (iterrations<= ramslots)
                {
                    for (int i = 0; i < iterrations; i++)
                    {
                        computer.Ram.Add(computer.UserAskRam());
                        ramslots -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Ammount of RAMs is to much that you Motherboard suppport!");
                }
            }
            else
            {
                Console.WriteLine("No motherboard, please add it");
            }
            break;
        
        case "4":
            if (computer.Mboard != null)
            {
                Console.Write("Ammount of GPUs: ");
                iterrations = Convert.ToInt32(Console.ReadLine());
                if (iterrations <= gpuslots)
                {
                    for (int i = 0; i < iterrations; i++)
                    {
                        computer.Gpu.Add(computer.UserAskGpu());
                        gpuslots -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Ammount of GPUs is to much that you Motherboard suppport!");
                }
            }
            else
            {
                Console.WriteLine("No motherboard, please add it");
            }
            break;
        
        case "5":
            if (computer.Mboard != null)
            {
                Console.Write("Ammount of Drives: ");
                iterrations = Convert.ToInt32(Console.ReadLine());
                if (iterrations <= driveslots)
                {
                    computer.Drive.Add(computer.UserAskDrive());
                    driveslots -= 1;
                }
                else
                {
                    Console.WriteLine("Ammount of Drives is to much that you Motherboard suppport!");
                }

            }
            else
            {
                Console.WriteLine("No motherboard, please add it");
            }
            break;

        case "i":
            Console.WriteLine(computer.ShowAllInfo());
            break;
        
        case "q":
            Environment.Exit(0);
            break;
        
    }
    
}
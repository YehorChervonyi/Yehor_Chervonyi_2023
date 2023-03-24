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
            MotherboardAsk();
            break;
        
        case "2":
            CpuAsk();
            break;
        
        
        case "3":
            RamAsk();
            break;
        
        case "4":
            GpuAsk();
            break;
        
        case "5":
            DriveAsk();
            break;

        case "i":
            Console.WriteLine(computer.ShowAllInfo());
            break;
        
        case "q":
            Environment.Exit(0);
            break;
        
    }
    
}

void MotherboardAsk()
{
    Dictionary<string, int> connectInterface = new Dictionary<string, int>();
    Console.WriteLine("Fill In");
    Console.Write("Price: ");
    int price = Convert.ToInt32(Console.ReadLine());

    Console.Write("Supplier: ");
    string supplier = Console.ReadLine();

    Console.Write("Country: ");
    string country = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Socket: ");
    string socket = Console.ReadLine();

    Console.Write("CPU slots ammount: ");
    int cpuslots = Convert.ToInt32(Console.ReadLine());

    Console.Write("DDR slots ammount: ");
    int slotsCount = Convert.ToInt32(Console.ReadLine());

    Console.Write("RAM support: ");
    string ramSupport = Console.ReadLine();

    Console.Write("GPUs support (ammount of PCI-E slots): ");
    int pcieslots = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ammount of types interfaces: ");
    var iterratons = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < iterratons; i++)
    {
        Console.Write("Connect interface: ");
        coninterface = Console.ReadLine();
        
        Console.Write($"Type ammount of {coninterface}: ");
        var ammount = Convert.ToInt32(Console.ReadLine()); 
        connectInterface.Add(coninterface,ammount);
    }
    var mboard = new Motherboard
        (
            price, supplier, country, name,
            socket, cpuslots, slotsCount, ramSupport,
            pcieslots, connectInterface
        );
    computer.AddMboard(mboard);
    cpuslotss = computer.Mboard.CpuSlots;
    gpuslots = computer.Mboard.PcieSlots;
    ramslots = computer.Mboard.SlotsCount;
    driveslots = computer.Mboard.ConnectInterface.Values.Count;
}

void CpuAsk()
{
    if (computer.Mboard != null)
    {
        Console.Write("Ammount of CPUs: ");
        iterrations = Convert.ToInt32(Console.ReadLine());
        if (iterrations <= cpuslotss)
        {
            for (int i = 0; i < iterrations; i++)
            {
                Console.WriteLine("Fill In");
                Console.Write("Price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Supplier: ");
                string supplier = Console.ReadLine();
                
                Console.Write("Country: ");
                string country = Console.ReadLine();
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Socket: ");
                string socket = Console.ReadLine();

                Console.Write("Cores: ");
                string cores = Console.ReadLine();

                Console.Write("Frequency: ");
                string frequency = Console.ReadLine();

                if (computer.Mboard.Socket == socket)
                {
                    var cpu = new Cpu(price, supplier, country, name, socket, cores, frequency);
                    computer.Cpu.Add(cpu);
                    cpuslotss -= 1;
                }
                else
                {
                    Console.WriteLine("\nWrong CPU socket! CPU wasn`t add\n");
                }
                
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
}

void RamAsk()
{
    if (computer.Mboard != null)
    {
        Console.Write("Ammount of RAMs: ");
        iterrations = Convert.ToInt32(Console.ReadLine());
        if (iterrations<= ramslots)
        {
            for (int i = 0; i < iterrations; i++)
            {
                Console.WriteLine("Fill In");
                Console.Write("Price: ");
                int price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Supplier: ");
                string supplier = Console.ReadLine();
        
                Console.Write("Country: ");
                string country = Console.ReadLine();
        
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Type: ");
                string type = Console.ReadLine();

                Console.Write("Size: ");
                string size = Console.ReadLine();

                if (computer.Mboard.RamSupport == type)
                {
                    var ram = new Ram(price, supplier, country, name, type, size);
                    computer.Ram.Add(ram);
                    ramslots -= 1;
                }
                else
                {
                    Console.WriteLine("\nWrong RAM type! RAM wasn`t add\n");
                }
                
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
}

void GpuAsk()
{
    if (computer.Mboard != null)
    {
        Console.Write("Ammount of GPUs: ");
        iterrations = Convert.ToInt32(Console.ReadLine());
        if (iterrations <= gpuslots)
        {
            for (int i = 0; i < iterrations; i++)
            {
                Console.WriteLine("Fill In");
                Console.Write("Price: ");
                int price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Supplier: ");
                string supplier = Console.ReadLine();
        
                Console.Write("Country: ");
                string country = Console.ReadLine();
        
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Memory: ");
                string memory = Console.ReadLine();

                Console.Write("Speed: ");
                string speed = Console.ReadLine();
                
                var gpu = new Gpu(price, supplier, country, name, memory, speed);
                computer.Gpu.Add(gpu);
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
}

void DriveAsk()
{
    if (computer.Mboard != null)
    {
        Console.Write("Ammount of Drives: ");
        iterrations = Convert.ToInt32(Console.ReadLine());
        if (iterrations <= driveslots)
        {
            Console.WriteLine("Fill In");
            Console.Write("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Supplier: ");
            string supplier = Console.ReadLine();
        
            Console.Write("Country: ");
            string country = Console.ReadLine();
        
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Size: ");
            string size = Console.ReadLine();

            Console.Write("Type: ");
            string type = Console.ReadLine();
    
            Console.Write("Connect Interface: ");
            string connectinterface = Console.ReadLine();
    
            Console.Write("Speed: ");
            string speed = Console.ReadLine();

            if (type == "SSD")
            {
                Console.Write("Lifetime: ");
                lifetime = Console.ReadLine();
            }

            var allInterfaces = from x in computer.Mboard.ConnectInterface where x.Value > 0 select x;
            foreach (var coninterface in allInterfaces)
            {
                if (coninterface.Key == connectinterface)
                {
                    var drive = new Drive(price, supplier, country, name, size, type, connectinterface, speed, lifetime);
                    computer.Mboard.ConnectInterface[$"{connectinterface}"] -= 1;
                    computer.Drive.Add(drive);
                    driveslots -= 1;
                }
                else
                {
                    Console.WriteLine("\nWrong Connection interface! Drive wasn`t add\n");
                }
            }
            
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
}

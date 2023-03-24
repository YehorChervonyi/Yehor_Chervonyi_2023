using task1.Classes.Details;

namespace task1.Classes;

public class Computer
{
    public Motherboard? Mboard { get; set; }
    public List<Ram>? Ram { get; set; } = new List<Ram>();
    public List<Cpu>? Cpu { get; set; } = new List<Cpu>();
    public List<Gpu>? Gpu { get; set; } = new List<Gpu>();
    public List<Drive>? Drive { get; set; } = new List<Drive>();

    public void AddMboard(Motherboard mboard)
    {
        Mboard = mboard;
    }

    public Motherboard UserAskMboard()
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
            string coninterface = Console.ReadLine();

            Console.Write($"Type ammount of {coninterface}: ");
            var ammount = Convert.ToInt32(Console.ReadLine());
            connectInterface.Add(coninterface, ammount);
        }

        var mboard = new Motherboard
        (
            price, supplier, country, name,
            socket, cpuslots, slotsCount, ramSupport,
            pcieslots, connectInterface
        );
        return mboard;
    }

    public Cpu UserAskCpu()
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

        if (this.Mboard.Socket == socket)
        {
            var cpu = new Cpu(price, supplier, country, name, socket, cores, frequency);
            return cpu;
        }
        else
        {
            Console.WriteLine("\nWrong CPU socket! CPU wasn`t add\n");
            return null;
        }
    }

    public Ram UserAskRam()
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

        if (this.Mboard.RamSupport == type)
        {
            var ram = new Ram(price, supplier, country, name, type, size);
            return ram;

        }
        else
        {
            Console.WriteLine("\nWrong RAM type! RAM wasn`t add\n");
            return null;
        }
    }

    public Gpu UserAskGpu()
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
        return gpu;
    }

    public Drive UserAskDrive()
    {
        string lifetime = "";
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

        var allInterfaces = from x in this.Mboard.ConnectInterface where x.Value > 0 select x;
        foreach (var coninterface in allInterfaces)
        {
            if (coninterface.Key == connectinterface)
            {
                var drive = new Drive(price, supplier, country, name, size, type, connectinterface, speed, lifetime);
                this.Mboard.ConnectInterface[$"{connectinterface}"] -= 1;
                return drive;

            }
            else
            {
                Console.WriteLine("\nWrong Connection interface! Drive wasn`t add\n");
                return null;
            }
        }

        return null;
    }

    public void AddMboardFromStock(Motherboard mboard)
    {
        this.Mboard =null;
        this.Cpu.Clear();
        this.Ram.Clear();
        this.Gpu.Clear();
        this.Drive.Clear();
        AddMboard(mboard);
        
    }

    public string ShowAllInfo()
    {
        string result = "\n--Computer Info--\n";

        if (this.Mboard != null)
        {
            result += Mboard.ShowInfo();
        }
        else
        {
            result += "No Motherboard\n";
        }

        if (this.Cpu != null)
        {
            if (this.Cpu.Count == 0)
            {
                result += "No CPU\n";
            }

            foreach (var cpu in this.Cpu)
            {
                result += cpu.ShowInfo();
            }
        }

        if (this.Ram != null)
        {
            if (this.Ram.Count == 0)
            {
                result += "No RAM\n";
            }

            foreach (var ram in this.Ram)
            {
                result += ram.ShowInfo();
            }
        }

        if (this.Gpu != null)
        {
            if (this.Gpu.Count == 0)
            {
                result += "No GPU\n";
            }

            foreach (var gpu in this.Gpu)
            {
                result += gpu.ShowInfo();
            }
        }

        if (this.Drive != null)
        {
            if (this.Drive.Count == 0)
            {
                result += "No Drive\n";
            }

            foreach (var drive in this.Drive)
            {
                result += drive.ShowInfo();
            }
        }

        return result;
    }

    public string ShortInfo()
    {
        string result = "\n--Cart--\n";

        if (this.Mboard != null)
        {
            result += $"Motherboard\t | Name: {this.Mboard.Name} (Price: {this.Mboard.Price})\n";
        }
        else
        {
            result += "No Motherboard\n";
        }

        if (this.Cpu != null)
        {
            if (this.Cpu.Count == 0)
            {
                result += "No CPU\n";
            }
            else
            {
                foreach (var cpu in this.Cpu)
                {
                    result += $"CPU\t\t | Name: {cpu.Name} (Price: {cpu.Price})\n";
                }
            }
        }

        if (this.Ram != null)
        {
            if (this.Ram.Count == 0)
            {
                result += "No RAM\n";
            }
            else
            {
                foreach (var ram in this.Ram)
                {
                    result += $"RAM\t\t | Name: {ram.Name} (Price: {ram.Price})\n";
                }
            }
        }

        if (this.Gpu != null)
        {
            if (this.Gpu.Count == 0)
            {
                result += "No GPU\n";
            }
            else
            {
                foreach (var gpu in this.Gpu)
                {
                    result += $"GPU\t\t | Name: {gpu.Name} (Price: {gpu.Price})\n";
                }
            }
        }

        if (this.Drive != null)
        {
            if (this.Drive.Count == 0)
            {
                result += "No Drive\n";
            }
            else
            {
                foreach (var drive in this.Drive)
                {
                    result += $"Drive\t\t | Name: {drive.Name} (Price: {drive.Price})\n";
                }
            }
        }

        return result;
    }
}
using task1.Classes.Details;

namespace task1.Classes;

public class Computer
{
    public Motherboard? Mboard { get; set; }
    public List<Ram>? Ram { get; set; } = new List<Ram>();
    public List<Cpu>? Cpu { get; set; } = new List<Cpu>();
    public List<Gpu>? Gpu { get; set; } = new List<Gpu>();
    public List<Drive>? Drive { get; set; } = new List<Drive>();
    public int? cartCount { get; set; } = 0;
    public int? cpuslots { get; set; } = 0;
    public int? ramslots { get; set; } = 0;
    public int? pcieslots { get; set; } = 0;
    public int? conninterfaces { get; set; } = 0;

    public void AddMboard(Motherboard mboard)
    {
        Mboard = mboard;
    }
    public void AddMboardFromStock(Motherboard mboard)
    {
        this.Mboard =null;
        this.Cpu.Clear();
        this.Ram.Clear();
        this.Gpu.Clear();
        this.Drive.Clear();
        this.AddMboard(mboard);
        this.cpuslots = this.Mboard.CpuSlots;
        this.ramslots = this.Mboard.SlotsCount;
        this.pcieslots = this.Mboard.PcieSlots;
        this.conninterfaces = this.Mboard.ConnectInterface.Values.Count;
        
    }

    
    public void CartMenu(IEnumerable<Detail> sortedlist)
    {
        Console.Write("a | Add to cart\n" +
                      "q | Quit browsing\n" +
                      ">");
        string userinput = Console.ReadLine();
        switch (userinput)
        {
            case "a":
                Console.Write("Add to cart(Name of Detail): ");
                userinput = Console.ReadLine();
                var whatdetail = sortedlist.First().GetType().ToString().Split(".").Last();
            
                foreach (var detail in sortedlist)
                {
                    if (detail.Name == userinput)
                    {
                        switch (whatdetail)
                        {
                            case "Motherboard":
                                this.cartCount = 0;
                                this.AddMboardFromStock((Motherboard)detail);
                                this.cartCount++;
                                break;
                            case "Cpu":
                                this.Cpu.Add((Cpu)detail);
                                this.cpuslots--;
                                this.cartCount++;
                                break;
                            case "Ram":
                                this.Ram.Add((Ram)detail);
                                this.ramslots--;
                                this.cartCount++;
                                break;
                            case "Gpu":
                                this.Gpu.Add((Gpu)detail);
                                this.pcieslots--;
                                this.cartCount++;
                                break;
                            case "Drive":
                                this.Drive.Add((Drive)detail);
                                this.conninterfaces--;
                                this.cartCount++;
                                break;
                        }
                    }
                }
                break;
            case "q":
                break;
        }
    }
    
    public void DetailRemove(IEnumerable<Detail> detaillist, string userinput)
    {
        var whatdetail = detaillist.First().GetType().ToString().Split(".").Last();
        foreach (var detail in detaillist)
        {
            if (detail.Name == userinput)
            {
                switch (whatdetail)
                {
                    case "Motherboard":
                        this.Mboard =null;
                        this.Cpu.Clear();
                        this.Ram.Clear();
                        this.Gpu.Clear();
                        this.Drive.Clear();
                        this.cartCount = 0;
                        break;
                    case "Cpu":
                        this.Cpu.Remove((Cpu)detail);
                        this.cartCount--;
                        this.cpuslots++;
                        break;
                    case "Ram":
                        this.Ram.Remove((Ram)detail);
                        this.cartCount--;
                        this.ramslots++;
                        break;
                    case "Gpu":
                        this.Gpu.Remove((Gpu)detail);
                        this.cartCount--;
                        this.pcieslots++;
                        break;
                    case "Drive":
                        this.Drive.Remove((Drive)detail);
                        this.cartCount--;
                        this.conninterfaces++;
                        break;
                }
            }
        }
    }

    public void AllCart()
    {
        Console.WriteLine(this.ShortInfo());
            Console.Write("r  | Remove element\n" +
                          "rs | Reset all in cart\n" +
                          "q  | Quit cart\n" +
                          ">");
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "r":
                    Console.WriteLine(this.ShortInfo());
                    if (this.cartCount == 0)
                    {
                        Console.WriteLine("Nothing to remove\n");
                    }
                    else
                    {
                        Console.Write("Enter  name of detail to remove: ");
                        userinput = Console.ReadLine();
                        if (this.Mboard.Name == userinput)
                        {
                            this.Mboard =null;
                            this.Cpu.Clear();
                            this.Ram.Clear();
                            this.Gpu.Clear();
                            this.Drive.Clear();
                            this.cartCount = 0;
                        }
                        if (this.Cpu.Count != 0)
                        {
                            DetailRemove(this.Cpu.ToList(), userinput);
                        }
                        if (this.Ram.Count != 0)
                        {
                            DetailRemove(this.Ram.ToList(), userinput);
                        }
                        if (this.Gpu.Count != 0)
                        {
                            DetailRemove(this.Gpu.ToList(), userinput);
                        }
                        if (this.Drive.Count != 0)
                        {
                            DetailRemove(this.Drive.ToList(), userinput);
                        }
                    }
                    break;
                case "rs":
                    Console.Write("Are you sure want to reset all from your cart? (Yes/No): ");
                    userinput = Console.ReadLine();
                    switch (userinput)
                    {
                        case "Yes":
                            this.Mboard =null;
                            this.Cpu.Clear();
                            this.Ram.Clear();
                            this.Gpu.Clear();
                            this.Drive.Clear();
                            this.cartCount = 0;
                            break;
                        case "No":
                            break;
                    }
                    break;
                case "q":
                    break;
            }

    }
    public void BuyComputter(int userBudget)
    {
        if (this.Mboard == null || this.Cpu.Count == 0 || this.Ram.Count == 0 || this.Gpu.Count == 0 || this.Drive.Count ==0)
        {
            Console.WriteLine("The computer is not fully (not workly) assembled\n");
        }
        else
        {
            int totalprice = this.Mboard.Price;
            foreach (var cpu in this.Cpu)
            {
                totalprice += cpu.Price;
            }
            foreach (var ram in this.Ram)
            {
                totalprice += ram.Price;
            }
            foreach (var gpu in this.Gpu)
            {
                totalprice += gpu.Price;
            }
            foreach (var drive in this.Drive)
            {
                totalprice += drive.Price;
            }
            if (totalprice>userBudget)
            {
                Console.WriteLine("Sorry, but you budget is too low for this computer setup");
                
            }
            else
            {
                Console.WriteLine(this.ShowAllInfo());
                Environment.Exit(0);
            }
        }
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
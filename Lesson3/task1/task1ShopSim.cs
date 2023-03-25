using task1;
using task1.Classes;
using task1.Classes.Details;

var stock = new DetailStock();
//Main programm
Console.Write("Enter your all computer budget: ");
int userBudget = Convert.ToInt32(Console.ReadLine());
var computer = new Computer();
string userinput;
int cartCount = 0;
int number;
int budget;
int cpuslots = 0;
int ramslots = 0;
int pcieslots = 0;
int conninterfaces = 0;

while (true)
{
    if (computer.Mboard!= null)
    {
        cartCount = 1 + computer.Cpu.Count + computer.Ram.Count + computer.Gpu.Count + computer.Drive.Count;
    }
    Console.Write("1 | Show available Motherboards\n" +
                  "2 | Show available CPUs\n" +
                  "3 | Show available RAMs\n" +
                  "4 | Show available GPUs\n" +
                  "5 | Show available Drives\n" + 
                 $"c | My Cart\t |{cartCount}| order(s)\n" +
                  "b | Buy computer\n" + 
                  "e | Exit programm\n" +
                  "> ");
    userinput = Console.ReadLine();

    switch (userinput)
    {
        case "1":
            IEnumerable<Motherboard> mboards = null;
            Console.Write("Set up a price range (Min-Max) or ( 0 ) to skip: ");
            userinput = Console.ReadLine();
            if (userinput.Contains("-"))
            {
                var pricerange = userinput.Split("-").ToList();
                mboards = from x in stock.motherboards where x.Price >= Convert.ToInt32(pricerange[0]) && x.Price <= Convert.ToInt32(pricerange[1]) orderby  x.Price select x;
            }
            else
            {
                mboards = from x in stock.motherboards where x.Price <= userBudget select x;
            }
            number = 1;
            foreach (var mboard in mboards)
            {
                Console.WriteLine($"\t | {number} |\n {mboard.ShowInfo()}");
                number++;
            }

            CartMenu(mboards);
            break;
        case "2":
            number = 1;
            if (computer.Mboard != null)
            {
                if (cpuslots >0)
                {
                    IEnumerable<Cpu> sortedcpus = null;
                    Console.Write("Set up a price range (Min-Max) or ( 0 ) to skip: ");
                    userinput = Console.ReadLine();
                    if (userinput.Contains("-"))
                    {
                        var pricerange = userinput.Split("-").ToList();
                        sortedcpus = from x in stock.cpus where x.Price >= Convert.ToInt32(pricerange[0]) && x.Price <= Convert.ToInt32(pricerange[1]) && x.Socket == computer.Mboard.Socket orderby x.Price select x;
                    }
                    else
                    {
                        sortedcpus = from x in stock.cpus where x.Price <= userBudget && x.Socket == computer.Mboard.Socket select x;
                    }
                    foreach (var cpu in sortedcpus)
                    {
                        Console.WriteLine($"\t{number}\n{cpu.ShowInfo()}");
                        number++;
                    }
                    CartMenu(sortedcpus);
                    
                }
                else
                {
                    Console.WriteLine("No free sockets on Motherboard");
                }
            }
            else
            {
                foreach (var cpu in stock.cpus)
                {
                    Console.WriteLine($"\t|{number}|\n{cpu.ShowInfo()}");
                    number++;
                }
                Console.WriteLine("You dont have Motherboard to add a CPU\n");
            }
            break;
        case "3":
            number = 1;
            if (computer.Mboard != null)
            {
                if (ramslots>0)
                {
                    IEnumerable<Ram> sortedrams = null;
                    Console.Write("Set up a price range (Min-Max) or ( 0 ) to skip: ");
                    userinput = Console.ReadLine();
                    if (userinput.Contains("-"))
                    {
                        var pricerange = userinput.Split("-").ToList();
                        sortedrams = from x in stock.rams where x.Price >= Convert.ToInt32(pricerange[0]) && x.Price <= Convert.ToInt32(pricerange[1]) && x.Type == computer.Mboard.RamSupport orderby x.Price select x;
                    }
                    else
                    {
                        sortedrams = from x in stock.rams where x.Price <= userBudget && x.Type == computer.Mboard.RamSupport select x;
                    }
                    foreach (var ram in sortedrams)
                    {
                        Console.WriteLine($"\t{number}\n{ram.ShowInfo()}");
                        number++;
                    }
                    CartMenu(sortedrams);
                }
                else
                {
                    Console.WriteLine("No free RAM slots on Motherboard");
                }
            }
            else
            {
                foreach (var ram in stock.rams)
                {
                    Console.WriteLine($"\t{number}\n{ram.ShowInfo()}");
                    number++;
                }
                Console.WriteLine("You dont have Motherboard to add a RAM\n");
            }
            break;
        case "4":
            number = 1;
            if (computer.Mboard != null)
            {
                if (pcieslots>0)
                {   
                    IEnumerable<Gpu> sortedgpus = null;
                    Console.Write("Set up a price range (Min-Max) or ( 0 ) to skip: ");
                    userinput = Console.ReadLine();
                    if (userinput.Contains("-"))
                    {
                        var pricerange = userinput.Split("-").ToList();
                        sortedgpus = from x in stock.gpus where x.Price >= Convert.ToInt32(pricerange[0]) && x.Price <= Convert.ToInt32(pricerange[1]) orderby x.Price select x;
                    }
                    else
                    {
                        sortedgpus = from x in stock.gpus where x.Price <= userBudget select x;
                    }
                    foreach (var gpu in sortedgpus)
                    {
                        Console.WriteLine($"\t{number}\n{gpu.ShowInfo()}");
                        number++;
                    }
                    CartMenu(sortedgpus);
                }
                else
                {
                    Console.WriteLine("No free PCI-E slots on Motherboard");
                }
            }
            else
            {
                foreach (var gpu in stock.gpus)
                {
                    Console.WriteLine($"\t{number}\n{gpu.ShowInfo()}");
                    number++;
                }
                Console.WriteLine("You dont have Motherboard to add a GPU\n");
            }
            break;
        case "5":
            number = 1;
            if (computer.Mboard != null)
            {
                if (conninterfaces>0)
                {
                    IEnumerable<Drive> sorteddrives = null;
                    Console.Write("Set up a price range (Min-Max) or ( 0 ) to skip: ");
                    userinput = Console.ReadLine();
                    if (userinput.Contains("-"))
                    {
                        var pricerange = userinput.Split("-").ToList();
                        sorteddrives = from x in stock.drives from y in computer.Mboard.ConnectInterface 
                            where x.Price >= Convert.ToInt32(pricerange[0]) && x.Price <= Convert.ToInt32(pricerange[1]) && x.ConnectInterface == y.Key && y.Value > 0 
                            orderby x.Price select x;
                    }
                    else
                    {
                        sorteddrives = from x in stock.drives
                            from y in computer.Mboard.ConnectInterface
                            where x.Price <= userBudget && x.ConnectInterface == y.Key && y.Value > 0
                            select x;
                    }
                    
                    foreach (var drive in sorteddrives)
                    {
                        Console.WriteLine($"\t{number}\n{drive.ShowInfo()}");
                        number++;
                    }
                    CartMenu(sorteddrives);
                }
                else
                {
                    Console.WriteLine("No free connection intrerfaces for drives");    
                }
            }
            else
            {
                foreach (var drive in stock.drives)
                {
                    Console.WriteLine($"\t{number}\n{drive.ShowInfo()}");
                    number++;
                }
                Console.WriteLine("You dont have Motherboard to add a Drives\n");
            }
            break;
        case "b":
            if (computer.Mboard == null || computer.Cpu.Count == 0 || computer.Ram.Count == 0 || computer.Gpu.Count == 0 || computer.Drive.Count ==0)
            {
                Console.WriteLine("The computer is not fully (not workly) assembled");
            }
            else
            {
                int totalprice = computer.Mboard.Price;
                foreach (var cpu in computer.Cpu)
                {
                    totalprice += cpu.Price;
                }
                foreach (var ram in computer.Ram)
                {
                    totalprice += ram.Price;
                }
                foreach (var gpu in computer.Gpu)
                {
                    totalprice += gpu.Price;
                }
                foreach (var drive in computer.Drive)
                {
                    totalprice += drive.Price;
                }
                if (totalprice>userBudget)
                {
                    Console.WriteLine("Sorry, but you budget is too low for this computer setup");
                }
                else
                {
                    Console.WriteLine(computer.ShowAllInfo());
                }
            }
            Environment.Exit(0);
            break;
        case "c":
            Console.WriteLine(computer.ShortInfo());
            Console.Write("r  | Remove element\n" +
                          "rs | Reset all in cart\n" +
                          "q  | Quit cart\n" +
                          ">");
            userinput = Console.ReadLine();
            switch (userinput)
            {
                case "r":
                    Console.WriteLine(computer.ShortInfo());
                    if (cartCount == 0)
                    {
                        Console.WriteLine("Nothing to remove\n");
                    }
                    else
                    {
                        Console.Write("Enter  name of detail to remove: ");
                        userinput = Console.ReadLine();
                        if (computer.Mboard.Name == userinput)
                        {
                            computer.Mboard =null;
                            computer.Cpu.Clear();
                            computer.Ram.Clear();
                            computer.Gpu.Clear();
                            computer.Drive.Clear();
                            cartCount = 0;
                        }
                        if (computer.Cpu.Count != 0)
                        {
                            DetailRemove(computer.Cpu.ToList());
                        }
                        if (computer.Ram.Count != 0)
                        {
                            DetailRemove(computer.Ram.ToList());
                        }
                        if (computer.Gpu.Count != 0)
                        {
                            DetailRemove(computer.Gpu.ToList());
                        }
                        if (computer.Drive.Count != 0)
                        {
                            DetailRemove(computer.Drive.ToList());
                        }
                    }
                    break;
                case "rs":
                    Console.Write("Are you sure want to reset all from your cart? (Yes/No): ");
                    userinput = Console.ReadLine();
                    switch (userinput)
                    {
                        case "Yes":
                            computer.Mboard =null;
                            computer.Cpu.Clear();
                            computer.Ram.Clear();
                            computer.Gpu.Clear();
                            computer.Drive.Clear();
                            cartCount = 0;
                            break;
                        case "No":
                            break;
                    }
                    break;
                case "q":
                    break;
            }
            break;
        case "e":
            Environment.Exit(0);
            break;
    }
}

void CartMenu(IEnumerable<Detail> sortedlist)
{
    Console.Write("a | Add to cart\n" +
                  "q | Quit browsing\n" +
                  ">");
    userinput = Console.ReadLine();
    switch (userinput)
    {
        case "a":
            Console.Write("Add to cart(Name of CPU): ");
            userinput = Console.ReadLine();
            var whatdetail = sortedlist.First().GetType().ToString().Split(".").Last();
            
            foreach (var detail in sortedlist)
            {
                if (detail.Name == userinput)
                {
                    switch (whatdetail)
                    {
                        case "Motherboard":
                            cartCount = 0;
                            computer.AddMboardFromStock((Motherboard)detail);
                            cpuslots = computer.Mboard.CpuSlots;
                            ramslots = computer.Mboard.SlotsCount;
                            pcieslots = computer.Mboard.PcieSlots;
                            conninterfaces = computer.Mboard.ConnectInterface.Values.Count;
                            break;
                        case "Cpu":
                            computer.Cpu.Add((Cpu)detail);
                            cpuslots--;
                            break;
                        case "Ram":
                            computer.Ram.Add((Ram)detail);
                            ramslots--;
                            break;
                        case "Gpu":
                            computer.Gpu.Add((Gpu)detail);
                            pcieslots--;
                            break;
                        case "Drive":
                            computer.Drive.Add((Drive)detail);
                            conninterfaces--;
                            break;
                    }
                }
            }
            break;
        case "q":
            break;
    }
}

void DetailRemove(IEnumerable<Detail> detaillist)
{
    var whatdetail = detaillist.First().GetType().ToString().Split(".").Last();
    foreach (var detail in detaillist)
    {
        if (detail.Name == userinput)
        {
            switch (whatdetail)
            {
                case "Motherboard":
                    computer.Mboard =null;
                    computer.Cpu.Clear();
                    computer.Ram.Clear();
                    computer.Gpu.Clear();
                    computer.Drive.Clear();
                    cartCount = 0;
                    break;
                case "Cpu":
                    computer.Cpu.Remove((Cpu)detail);
                    cartCount--;
                    cpuslots++;
                    break;
                case "Ram":
                    computer.Ram.Remove((Ram)detail);
                    cartCount--;
                    ramslots++;
                    break;
                case "Gpu":
                    computer.Gpu.Remove((Gpu)detail);
                    cartCount--;
                    pcieslots++;
                    break;
                case "Drive":
                    computer.Drive.Remove((Drive)detail);
                    cartCount--;
                    conninterfaces++;
                    break;
            }
        }
    }
}
using task1;
using task1.Classes;
using task1.Classes.Details;

var stock = new DetailStock();
//Main programm
Console.Write("Enter your all computer budget: ");
int userBudget = Convert.ToInt32(Console.ReadLine());
var computer = new Computer();
string userinput;
int? cartCount = computer.cartCount;
int number;

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

            computer.CartMenu(mboards);
            break;
        case "2":
            number = 1;
            if (computer.Mboard != null)
            {
                if (computer.cpuslots >0)
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
                        Console.WriteLine($"\t| {number} |\n{cpu.ShowInfo()}");
                        number++;
                    }
                    computer.CartMenu(sortedcpus);
                    
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
                    Console.WriteLine($"\t| {number} |\n{cpu.ShowInfo()}");
                    number++;
                }
                Console.WriteLine("You dont have Motherboard to add a CPU\n");
            }
            break;
        case "3":
            number = 1;
            if (computer.Mboard != null)
            {
                if (computer.ramslots>0)
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
                        Console.WriteLine($"\t| {number} |\n{ram.ShowInfo()}");
                        number++;
                    }
                    computer.CartMenu(sortedrams);
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
                    Console.WriteLine($"\t| {number} |\n{ram.ShowInfo()}");
                    number++;
                }
                Console.WriteLine("You dont have Motherboard to add a RAM\n");
            }
            break;
        case "4":
            number = 1;
            if (computer.Mboard != null)
            {
                if (computer.pcieslots>0)
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
                        Console.WriteLine($"\t| {number} |\n{gpu.ShowInfo()}");
                        number++;
                    }
                    computer.CartMenu(sortedgpus);
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
                    Console.WriteLine($"\t| {number} |\n{gpu.ShowInfo()}");
                    number++;
                }
                Console.WriteLine("You dont have Motherboard to add a GPU\n");
            }
            break;
        case "5":
            number = 1;
            if (computer.Mboard != null)
            {
                if (computer.conninterfaces>0)
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
                        Console.WriteLine($"\t| {number} |\n{drive.ShowInfo()}");
                        number++;
                    }
                    computer.CartMenu(sorteddrives);
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
                    Console.WriteLine($"\t| {number} |\n{drive.ShowInfo()}");
                    number++;
                }
                Console.WriteLine("You dont have Motherboard to add a Drives\n");
            }
            break;
        case "c":
            computer.AllCart();
            break;
        case "b":
            computer.BuyComputter(userBudget);
            break;
        case "e":
            Environment.Exit(0);
            break;
    }
}
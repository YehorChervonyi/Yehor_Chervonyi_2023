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
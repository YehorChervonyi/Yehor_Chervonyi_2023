namespace task1;
using task1.Classes.Details;

public class DetailStock
{
    public List<Motherboard> motherboards = new List<Motherboard>()
    {
        new Motherboard
            (
                6000,
                "ASUS",
                "USA",
                "PRIME H670-PLUS D4",
                "s1700",
                1,
                4,
                "DDR4",
                3,
                new Dictionary<string, int>()
                {
                    {"SATA6", 2},
                    {"M.2", 3}
                }
            ),
        new Motherboard
            (
                1800,
                "ASRock",
                "USA",
                "H81 Pro BTC",
                "s1150",
                1,
                2,
                "DDR3",
                1,
                new Dictionary<string, int>()
                {
                    {"SATA3", 2},
                    {"SATA6", 2}
                }
            ),
        new Motherboard
        (
            300,
            "ASUS",
            "USA",
            "P5K SE/EPU",
            "s775",
            1,
            4,
            "DDR2",
            1,
            new Dictionary<string, int>()
            {
                {"SATA3", 4},
                {"IDE", 1}
            }
        )

    };
    public List<Cpu> cpus = new List<Cpu>()
    {
        new Cpu
            (
                7000,
                "Intel",
                "USA",
                "I5-12400F",
                "s1700",
                "6/12",
                "4000MHz"
            ),
        new Cpu
            (
                21000,
                "Intel",
                "USA",
                "I9-12900K",
                "s1700",
                "16/24",
                "5200MHz"
            ),
        new Cpu
            (
                2000,
                "Intel",
                "USA",
                "I5-4670K",
                "s1150",
                "4/4",
                "3800MHz"
            ),
        new Cpu
            (
                1750,
                "Intel",
                "USA",
                "Xeon E3-1270v3",
                "s1150",
                "4/8",
                "3900MHz"       
            ),
        
        new Cpu
            (
                250,
                "Intel",
                "USA",
                "Core 2 Quad Q6600",
                "s775",
                "4/4",
                "2400MHz"
            ),
        new Cpu
            (
                100,
                "Intel",
                "USA",
                "Core 2 Duo E7500",
                "s775",
                "2/2",
                "2930MHz"
            )
    };
    public List <Ram> rams = new List<Ram>()
    {
        new Ram
            (
            1000,
            "Kingston",
            "USA",
            "HyperX Fury Beast Black 16GB",
            "DDR4",
            "16384MB"
            ),
        new Ram
        (
            1000,
            "Kingston",
            "USA",
            "HyperX Fury Beast Black 8GB",
            "DDR4",
            "8192MB"
        ),
        new Ram
        (
            1100,
            "GOODRAM",
            "USA",
            "Iridium black",
            "DDR4",
            "8192MB"
        ),
        new Ram
        (
            700,
            "eXeleram",
            "USA",
            "eXeleram E40424A",
            "DDR4",
            "4096MB"
        ),
        new Ram
        (
            550,
            "GOODRAM",
            "USA",
            "GOODRAM GR1600D364L11S/4G",
            "DDR3",
            "4096MB"
        ),
        new Ram
        (
            2200,
            "Kingston",
            "USA",
            "HyperX Fury Black 8G",
            "DDR3",
            "8192MB"
        ),
        new Ram
        (
            650,
            "Golden Memory",
            "USA",
            "PC2-6400",
            "DDR2",
            "4096MB"
        ),
        new Ram
        (
            225,
            "Nanya",
            "USA",
            "NT2GT64U8HD0BY-AD",
            "DDR2",
            "2048MB"
        ),
        new Ram
        (
            215,
            "A-Tech",
            "USA",
            "AT2G1D2D800NA0N18V",
            "DDR2",
            "2048MB"
        ),
        new Ram
        (
            350,
            "Transcend",
            "USA",
            "JetRam",
            "DDR2",
            "2048MB"
        ),
    };
    public List<Drive> drives = new List<Drive>()
    {
        new Drive
        (
            5000,
            "Gigabyte",
            "USA",
            "Aorus",
            "1TB",
            "SSD",
            "M.2",
            "7000MB/s | 5500MB/s",
            "182,5 years"
        ),
        new Drive
        (
            5200,
            "Samsung",
            "USA",
            "MZ-V8V1T0BW",
            "1TB",
            "SSD",
            "M.2",
            "3500MB/s | 3000MB/s",
            "160 years"
        ),
        new Drive
        (
            1500,
            "WD",
            "USA",
            "Western Digital Blue WD5000AZLX",
            "500GB",
            "HDD",
            "SATA3",
            "350MB/s | 300MB/s",
            null
        ),
        new Drive
        (
            2000,
            "WD",
            "USA",
            "Western Digital Purple WD10PURZ",
            "1TB",
            "HDD",
            "SATA3",
            "320MB/s | 260MB/s",
            null
        ),
        new Drive
        (
            1200,
            "Kingston",
            "USA",
            "Now A400 3D v-NAND",
            "480GB",
            "SSD",
            "SATA6",
            "500MB/s | 450MB/s",
            "115 years"
        ),
        new Drive
        (
            3200,
            "Samsung",
            "USA",
            "870 QVO V-NAND",
            "1TB",
            "SSD",
            "SATA6",
            "560MB/s | 530MB/s",
            "170 years"
        ),
        new Drive
        (
            350,
            "Seagate",
            "USA",
            "HD ST3160022ACE",
            "160GB",
            "HDD",
            "IDE",
            "120MB/s | 100MB/s",
            "20 years"
        ),
    };
    public List<Gpu> gpus = new List<Gpu>()
    {
        new Gpu
            (
                20000,
                "ASUS",
                "USA",
                "GeForce RTX3060TI Dual",
                "8GB",
                "1740MHz"
            ),
        new Gpu
        (
            4500,
            "ASUS",
            "USA",
            "GeForce GTX 1050 Expeditipon OC",
            "2GB",
            "1518MHz"
        ),
    };
}
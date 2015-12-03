using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace PC_Catalog
{
    class PC_Catalog
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("be-BG");

            var config1 = new Computer("Techno-X2 2650N", new Dictionary<string, Components> {
                        {"case",new Components("Neotech 2123", "Black, with PSU 400W", 50.60m)},
                        {"motherboard", new Components("ASUS AM1M-A","Vga HDMI, 2xDDR3, 1xPCIE16, 4xUSB3",66.84m)},
                        { "processor", new Components("Sempron X2 2650", 56.72m) },
                        { "RAM", new Components("Corsair DDR3 4GB", 61.57m) },
                        {"HDD",new Components("Seagate HDD 500GB","7200.12, 16MB, S-ATA3",111.75m)},
                        { "keyboard", new Components("Logitech K120", 25.93m) },
                        { "mouse", new Components("Logitech B100", 16.45m) }
                    });

            var config2 = new Computer("Game/Work PC X99-A", new Dictionary<string, Components>());
            config2.Components.Add("case", new Components("CM Middle HAF 912 Advanced", "no PSU", 199.47m));
            config2.Components.Add("motherboard", new Components("ASUS X99-A", 590.39m));
            config2.Components.Add("processor", new Components("Intel i7-5820K", "3.3/15M/s2011-V3, Box", 887.48m));
            config2.Components.Add("PSU", new Components("Corsair RM850", "850W, Modular, 80+ Gold", 356.13m));

            Computer config3 = new Computer("Asus 8789");
            List<Computer> configs = new List<Computer> { config1, config2, config3 };

            var query = from x in configs orderby x.Price select x;
            foreach (var x in query)
            {
                x.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}

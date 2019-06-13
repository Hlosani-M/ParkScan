using System;
using System.Collections.Generic;
using System.Text;

namespace ParkScan.Model
{
    public class MasterMenuItem
    {
        public string MenuItemName { get; set; }

        public string Image { get; set; }

        public MasterMenuItem() {}
        public MasterMenuItem(string item, string image)
        {
            MenuItemName = item;
            Image = image;
        }
    }
}

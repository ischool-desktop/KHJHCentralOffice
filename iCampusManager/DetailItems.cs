﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesktopLib;

namespace iCampusManager
{
    internal class DetailItems
    {
        public DetailItems()
        {
            Program.MainPanel.RegisterDetailContent<BasicInfoItem>();
            Program.MainPanel.RegisterDetailContent<NetworkItem>();
            Program.MainPanel.RegisterDetailContent<UDMItem>();
            Program.MainPanel.RegisterDetailContent<UDTItem>();
            Program.MainPanel.RegisterDetailContent<UDSItem>();
            Program.MainPanel.RegisterDetailContent<ModuleItem>();
            Program.MainPanel.RegisterDetailContent<WebGadgetItem>();
            Program.MainPanel.RegisterDetailContent<StudentExchangeReset>();
        }
    }
}

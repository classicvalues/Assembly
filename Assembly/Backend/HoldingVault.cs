﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assembly.Backend
{
    public class HoldingVault
    {
        public const string XboxChaosServer = "https://xboxchaos.com/assemblyweb/api/hub.php";
        public const string XboxChaosUpdateServer = "http://assembly.xboxchaos.com/Updater/ShuttleBay/";

        public static readonly Uri XboxChaosHReachTuts = new Uri("http://www.xboxchaos.com/index.php?app=core&module=global&section=rss&type=forums&id=1");
        public static readonly Uri XboxChaosH3Tuts = new Uri("http://www.xboxchaos.com/index.php?app=core&module=global&section=rss&type=forums&id=2");
    }
}
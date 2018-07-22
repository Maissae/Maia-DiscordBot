﻿using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Core.Common
{
    interface IConnectionHandler
    {
        Task Connect();
        Task Disconnect();
        DiscordSocketClient Client { get; }
    }
}

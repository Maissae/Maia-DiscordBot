﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Core.Commands
{
    interface ICommand
    {
        Task Execute();
        string Help { get; }
    }
}

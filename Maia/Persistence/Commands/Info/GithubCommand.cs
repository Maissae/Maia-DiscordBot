﻿using Discord;
using Maia.Core.Commands;
using Maia.Core.Common;
using Maia.Core.Settings;
using Maia.Core.Validation;
using Maia.Persistence.Validation.Context;
using Maia.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maia.Persistence.Commands.Info
{
    class GithubCommand : BaseCommand, ICommand
    {
        public GithubCommand(IUser author, IConfiguration config, IMessageChannel channel, IMessageWriter messageWriter, IValidationHandler validationHandler, params string[] parameters) 
            : base(author, config, channel, messageWriter, validationHandler, parameters)
        {
        }

        public override bool CanExecute()
        {
            ICommandValidationContext context = new NoParametersValidationContext(_config);
            var result = _validationHandler.Validate(context, this);
            return result.IsSuccessful;
        }

        public override async Task ExecuteAsync()
        {
            if(CanExecute())
                await _messageWriter.Send(Resources.Info.projectRepositoryURL, Author, Channel);
            else
                await _messageWriter.Send("Invalid use of command!", Author, Channel);
        }
    }
}

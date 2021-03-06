﻿using Maia.Core.Commands;
using Maia.Core.Settings;
using Maia.Core.Validation;
using Maia.Persistence.Validation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maia.Persistence.Validation.Context
{
    class RandomCommandValidationContext : BaseCommandValidationContext, ICommandValidationContext
    {
        public RandomCommandValidationContext(IConfiguration config) : base(config)
        {
        }

        public override IEnumerable<ValidationResult> Validate(BaseCommand command)
        {
            List<ValidationResult> validationResults = new List<ValidationResult>();
            var parametersValidator = new RandomCommandParametersValidator(_config);
            validationResults.Add(parametersValidator.Validate(command));
            return validationResults;
        }
    }
}

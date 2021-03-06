﻿using System;

namespace Esquio.UI.Client.ViewModels
{
    public class ToggleParameterViewModel
    {
        public ToggleParameterViewModel(
            string name,
            string clrType,
            string value = default,
            string deploymentName = default,
            int order = default,
            string description = default)
        {
            Name = name;
            ClrType = clrType;
            Value = value;
            DeploymentName = deploymentName;
            Order = order;
            Description = description;
        }


        public string Name { get; set; }

        public string ClrType { get; set; }

        public string Value { get; set; }

        public string DeploymentName { get; set; }

        public int Order { get; set; }

        public string Description { get; set; }

        public bool IsEmpty => !Value.HasValue();

        public ToggleParameterViewModel ShallowCopy(string value)
        {
            var copy = (ToggleParameterViewModel)this.MemberwiseClone();
            copy.Value = value;
            return copy;
        }
    }
}
